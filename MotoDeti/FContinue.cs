using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MotoDeti
{
    public partial class FContinue : Form
    {
        private GameDB db = GameDB.getInstance();
        FMap mapForm = new FMap();
        public string ConnectStr = @"Data Source=.\motodeti.db; Version=3;";
        private SQLiteConnection connect;
        private SQLiteDataAdapter adapter = null;
        private DataTable table = null;
        private bool orderAsc = true;
        public FContinue()
        {
            InitializeComponent();
            adapter = new SQLiteDataAdapter("SELECT * FROM Players", ConnectStr);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshTable()
        {
            var filter = cb_filt.SelectedItem as string;

            var whereClause = "";
            if (!string.IsNullOrEmpty(filter) && filter != "Все")
            {
                whereClause += "where ";
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

            var orderClause = "";
            if (orderAsc)
            {
                orderClause += "order by nickname asc";
            }
            else
            {
                orderClause += "order by nickname desc";
            }
            connect = new SQLiteConnection(ConnectStr);
            adapter.SelectCommand = new SQLiteCommand("select * from Players " + whereClause + " " + orderClause, connect);

            table = new System.Data.DataTable();
            adapter.Fill(table);
            dgv_players.DataSource = table;
            dgv_players.Columns[0].Visible = false;
            dgv_players.Columns[1].HeaderText = "Никнейм";
            dgv_players.Columns[2].HeaderText = "Возраст";
            dgv_players.Columns[3].HeaderText = "Город";
            dgv_players.Columns[4].HeaderText = "Школа";
            dgv_players.Columns[5].HeaderText = "Класс";
            dgv_players.Columns[6].HeaderText = "";
        }

        private void FContinue_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_players.RowCount; i++)
            {
                dgv_players.Rows[i].Selected = false;
                for (int j = 0; j < dgv_players.ColumnCount; j++)
                    if (dgv_players.Rows[i].Cells[j].Value != null)
                        if (dgv_players.Rows[i].Cells[j].Value.ToString().Contains(tb_search.Text))
                        {
                            dgv_players.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void cb_filt_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            orderAsc = !orderAsc;

            refreshTable();
        }

        private void btn_game_Click(object sender, EventArgs e)
        {
            if (dgv_players.SelectedRows.Count == 0) return;

            var row = dgv_players.SelectedRows[0];
            var playerId = Convert.ToInt32(row.Cells[0].Value);

            var gameInfo = db.GetGameInfo(playerId);

            mapForm.GameInfo = gameInfo;
            mapForm.ShowDialog(this);
        }
    }
}
