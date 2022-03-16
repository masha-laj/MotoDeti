using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDeti
{
    public struct LevelProgress
    {
        public int state;
        public int timeleft;
    }

    public struct PlayerRegData
    {
        public string nickname;
        public int age;
        public string town;
        public string school;
        public object number;
        public object letter;
    }

    public class GameInfo
    {
        public int gameId { get; set; }
        public int playerId { get; set; }
        public int lastLevel { get; set; }
        public int levelTime { get; set; }
        public int maxLives { get; set; }
        public int lives { get; set; }
        public bool showTip { get; set; }

        public Dictionary<int, LevelProgress> levelsProgress;

        public void GameDB()
        {
            levelsProgress = new Dictionary<int, LevelProgress>();
        }

        public void SetLastLevel(int lastLevel)
        {
            this.lastLevel = lastLevel;
        }
    }

    public class GameDB
    {
        private static GameDB instance;

        private string connectStr = @"Data Source=.\motodeti.db; Version=3;";

        private GameDB() { }

        public static GameDB getInstance()
        {
            if (instance == null)
                instance = new GameDB();
            return instance;
        }

        private SQLiteConnection GetConnection()
        {
            var connect = new SQLiteConnection(connectStr);
            connect.Open();

            return connect;
        }

        private SQLiteCommand GetCommand(string query)
        {
            return new SQLiteCommand(query, GetConnection());
        }

        public int AddPlayer(PlayerRegData data)
        {
            string query = "INSERT INTO Players (nickname, age, town, school, number, letter) VALUES (@nickname, @age, @town, @school, @number, @letter)";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@nickname", DbType.String).Value = data.nickname;
                cmd.Parameters.Add("@age", DbType.Int32).Value = data.age;
                cmd.Parameters.Add("@town", DbType.String).Value = data.town;
                if (string.IsNullOrWhiteSpace(data.school))
                    cmd.Parameters.Add("@school", DbType.String).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@school", DbType.String).Value = data.school;

                if (data.number == null)
                    cmd.Parameters.Add("@number", DbType.Int32).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@number", DbType.Int32).Value = data.number;

                if (data.letter == null)
                    cmd.Parameters.Add("@letter", DbType.String).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@letter", DbType.String).Value = data.letter;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            int playerId;
            query = "SELECT id FROM Players WHERE nickname = @nickname";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@nickname", DbType.String).Value = data.nickname;
                cmd.CommandType = CommandType.Text;
                playerId = int.Parse(cmd.ExecuteScalar().ToString());
            }

            query = "INSERT INTO Games (player_id, last_lvl, level_time, lives, max_lives, show_tip) VALUES (@player_id, @last_lvl, @level_time, @lives, @max_lives, @show_tip)";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@player_id", DbType.Int32).Value = playerId;
                cmd.Parameters.Add("@last_lvl", DbType.Int32).Value = 0;
                cmd.Parameters.Add("@level_time", DbType.Int32).Value = Properties.Settings.Default.answertime_single;
                cmd.Parameters.Add("@lives", DbType.Int32).Value = Properties.Settings.Default.attempts;
                cmd.Parameters.Add("@max_lives", DbType.Int32).Value = Properties.Settings.Default.attempts;
                cmd.Parameters.Add("@show_tip", DbType.Boolean).Value = Properties.Settings.Default.help;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            return playerId;
        }

        public GameInfo GetGameInfo(int playerId)
        {
            var info = new GameInfo();

            var query = "SELECT * FROM Games WHERE player_id = @id";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = playerId;
                cmd.CommandType = CommandType.Text;

                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (!reader.HasRows) throw new Exception("Game not found");
                reader.Read();
                info.gameId = reader.GetInt32(0);
                info.playerId = reader.GetInt32(1);
                info.lastLevel = reader.GetInt32(2);
                info.levelTime = reader.GetInt32(3);
                info.lives = reader.GetInt32(4);
                info.maxLives = reader.GetInt32(5);
                info.levelsProgress = GetLevelsProgress(info.gameId);
                info.showTip = reader.GetBoolean(6);
                reader.Close();
            }

            return info;
        }

        public void DeletePlayer(int playerId)
        {
            var query = "DELETE FROM Players WHERE id = @id";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = playerId;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        private Dictionary<int, LevelProgress> GetLevelsProgress(int gameId)
        {
            var progress = new Dictionary<int, LevelProgress>();

            var query = "SELECT * FROM Games_Levels WHERE game_id = @id";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = gameId;
                cmd.CommandType = CommandType.Text;

                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var level = reader.GetInt32(1);
                        var result = reader.GetInt32(2);
                        var timeleft = reader.GetInt32(3);

                        progress.Add(level, new LevelProgress { state = result, timeleft = timeleft });
                    }
                }
                reader.Close();
            }

            return progress;
        }

        public void SaveGame(GameInfo info)
        {
            var query = "UPDATE Games SET last_lvl = @last_lvl, lives = @lives WHERE id = @id";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = info.gameId;
                cmd.Parameters.Add("@last_lvl", DbType.Int32).Value = info.lastLevel;
                cmd.Parameters.Add("@lives", DbType.Int32).Value = info.lives;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            query = "DELETE FROM Games_Levels WHERE game_id = @id";
            using (var cmd = GetCommand(query))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = info.gameId;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            foreach (var lvl in info.levelsProgress.Keys)
            {
                var progress = info.levelsProgress[lvl];

                query = "INSERT INTO Games_Levels (game_id, level, result, timeleft) VALUES (@game_id, @level, @result, @timeleft)";
                using (var cmd = GetCommand(query))
                {
                    cmd.Parameters.Add("@game_id", DbType.Int32).Value = info.gameId;
                    cmd.Parameters.Add("@level", DbType.Int32).Value = lvl;
                    cmd.Parameters.Add("@result", DbType.Int32).Value = progress.state;
                    cmd.Parameters.Add("@timeleft", DbType.Int32).Value = progress.timeleft;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SQLiteCommand GetTop(string filter, bool orderAsc)
        {
            var whereClause = ""; 
            var orderClause = "";

            if (!string.IsNullOrEmpty(filter) && filter != "Все")
            {
                whereClause += "AND ";
                if (filter == "Школьники")
                {
                    whereClause += "school is not null";
                }
                else if (filter == "Выпускники")
                {
                    whereClause += "school is null";
                }
                else whereClause = "";
            }
            if (orderAsc)
            {
                orderClause += "order by nickname asc";
            }
            else
            {
                orderClause += "order by nickname desc";
            }

            var query = $"SELECT " +
                            "p.id, " +
	                        "p.nickname, " +
	                        "p.age, " +
	                        "p.town, " +
	                        "p.school, " +
	                        "p.number, " +
	                        "p.letter, " +
	                        "g.max_lives - g.lives as lives, " +
	                        "sum(gl.timeleft) as time " +
                        "FROM players p " +
                        "INNER JOIN games g ON g.player_id = p.id " +
                        "INNER JOIN games_levels gl ON gl.game_id = g.id " +
                        $"WHERE g.last_lvl >= 10 {whereClause}" +
                        $" GROUP BY p.id {orderClause};";
            return GetCommand(query);
        }
    }
}
