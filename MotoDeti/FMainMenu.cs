using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;

namespace MotoDeti
{
    public partial class FMainMenu : Form
    {
        MediaPlayer mp = new MediaPlayer();
        FSet f2 = new FSet();
        FSingle f3 = new FSingle();
        FMemo f11 = new FMemo();
        FTeam f13;

        SplashScreen ss;
        public FMainMenu()
        {
            InitializeComponent();
        }

        private void FMainMenu_Load(object sender, EventArgs e)
        {
            mp.Volume = Properties.Settings.Default.volume / 100.0;
            //mp.Volume = 0;
            mp.Open(new Uri(Environment.CurrentDirectory + "\\Resources\\Polugora_KurtDonaldCobain.wav", UriKind.Relative));
            mp.MediaEnded += Mp_MediaEnded;
            mp.Play();

            f2.mp = mp;
        }

        private void Mp_MediaEnded(object sender, EventArgs e)
        {
            mp.Position = TimeSpan.Zero;
            mp.Play();
        }

        private void btn_memo_Click(object sender, EventArgs e)
        {
            f11.ShowDialog(this);
        }

        private void btn_single_game_Click(object sender, EventArgs e)
        {
            f3.ShowDialog(this);
        }

        private void btn_team_game_Click(object sender, EventArgs e)
        {
            f13 = new FTeam();
            f13.ShowDialog(this);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
