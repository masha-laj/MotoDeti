using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FTeam : Form
    {
        private Dictionary<int, LevelData> levels = LvlsCreator.Levels();
        private const string PL1 = "Player1";
        private const string PL2 = "Player2";
        private Dictionary<string, PlayerInfo> players = new Dictionary<string, PlayerInfo>()
        {
            { PL1, new PlayerInfo() { Address = "", Nickname = "КОМАНДА 1", Score = 0 } },
            { PL2, new PlayerInfo() { Address = "", Nickname = "КОМАНДА 2", Score = 0 } },
        };

        MobileControl mc = new MobileControl();

        private List<int> levelsQueue = new List<int>();
        private int _piconnect = 0;

        private FTeamLevel levelForm;
        public FTeam()
        {
            InitializeComponent();

            mc.Connected += Mc_Connected;

            MakeLevelsQueue();

            ip_address.Text = GetLocalIPAddress();
        }

        private void UpdateForm()
        {
            lbl_left_num.Text = levelsQueue.Count.ToString();
            lbl_team1.Text = players[PL1].Nickname;
            lbl_team1_num.Text = players[PL1].Score.ToString();
            lbl_team2.Text = players[PL2].Nickname;
            lbl_team2_num.Text = players[PL2].Score.ToString();
        }

        private void LevelForm_SocketAnswer(object sender, SocketAnswerEventArgs e)
        {
            var player = GetPlayerInfoByAddress(e.Address);
            if (e.Correct)
                player.Score++;
            e.Team = player.Nickname;
            this.Invoke(new MethodInvoker(() =>
            {
                UpdateForm();
            }));
        }

        private void LevelForm_Answer(object sender, AnswerEventArgs e)
        {
            var player = players[e.Player];
            if (e.Correct)
                player.Score++;
            e.Team = player.Nickname;
            UpdateForm();
        }

        private void MakeLevelsQueue()
        {
            levelsQueue.Clear();
            for (var i = 1; i <= 10; i++) levelsQueue.Add(i);
            var rnd = new Random();
            levelsQueue = levelsQueue.OrderBy(item => rnd.Next()).ToList();
        }

        private PlayerInfo GetPlayerInfoByAddress(string address)
        {
            return players.Values.FirstOrDefault(t => t.Address == address);
        }

        private void Mc_Connected(object sender, MobileCOntrolEventArgs e)
        {
            if (_piconnect > 1) return;
            if (_piconnect == 0)
            {
                players[PL1] = new PlayerInfo() { Address = e.Address, Nickname = e.Args[0], Score = 0 };
            } else if (_piconnect == 1)
            {
                players[PL2] = new PlayerInfo() { Address = e.Address, Nickname = e.Args[0], Score = 0 };
            }
            Invoke(new MethodInvoker(() =>
            {
                UpdateForm();
            }));
            _piconnect++;
        }

        private void Socket_MessageReceived(object sender, UDPSocketMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.Endpoint.ToString() + ": " + e.Message);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            timer1.Start();

            NextLevel();
        }

        private void NextLevel()
        {
            if (levelsQueue.Count > 0)
            {
                var lvl = levelsQueue[0];
                levelsQueue.RemoveAt(0);


                levelForm = new FTeamLevel();
                levelForm.SetLevel(levels[lvl]);
                levelForm.SetSocket(mc);
                levelForm.Answer += LevelForm_Answer;
                levelForm.SocketAnswer += LevelForm_SocketAnswer;
                levelForm.ShowDialog();

                if (levelsQueue.Count == 0)
                {
                    ShowResult();
                }
            }
        }

        private void ShowResult()
        {
            levelForm.Close();

            var goForm = new FGameOver();
            var tm1s = players.ContainsKey(PL1) ? players[PL1].Score : 0;
            var tm2s = players.ContainsKey(PL2) ? players[PL2].Score : 0;
            var tm1n = players.ContainsKey(PL1) ? players[PL1].Nickname : "Команда 1";
            var tm2n = players.ContainsKey(PL2) ? players[PL2].Nickname : "Команда 2";

            var text = tm1s == tm2s ? "Ничья" : tm1s > tm2s ? tm1n : tm2n;

            goForm.Team = text;

            if (goForm.ShowDialog() == DialogResult.Yes)
            {
                // restart
                MakeLevelsQueue();
                timer1.Stop();
                pB_time.Value = 0;
                pB_time.Minimum = 0;
                pB_time.Maximum = Properties.Settings.Default.gametime;
                players[PL1].Score = 0;
                players[PL2].Score = 0;
                UpdateForm();
            } else
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pB_time.Value++;
            if (pB_time.Value == pB_time.Maximum)
            {
                timer1.Stop();
                ShowResult();
                return;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            mc.Destroy();
        }

        private void FTeam_Load(object sender, EventArgs e)
        {
            pB_time.Value = 0;
            pB_time.Minimum = 0;
            pB_time.Maximum = Properties.Settings.Default.gametime;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
