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
    public partial class FSet : Form
    {
        public MediaPlayer mp;

        public FSet()
        {
            InitializeComponent();
        }
       
        private void FSet_Load(object sender, EventArgs e)
        {
            chb_team.Checked = Properties.Settings.Default.team_game;
            var attempts = Properties.Settings.Default.attempts.ToString();
            cb_attempts.SelectedItem = attempts;
            var answertime_single = Properties.Settings.Default.answertime_single.ToString();
            cb_answertime_single.SelectedItem = answertime_single;
            chb_help.Checked = Properties.Settings.Default.help;
            cb_gametime.SelectedItem = Properties.Settings.Default.gametime;
            cb_answertime_team.SelectedItem = Properties.Settings.Default.answertime_team;
            cb_btn_answer1.SelectedItem = Properties.Settings.Default.btn_answer1;
            cb_btn_answer2.SelectedItem = Properties.Settings.Default.btn_answer2;
            trb_sound.Value = Properties.Settings.Default.volume;

            if (chb_team.Checked)
            {
                gb_team.Enabled = true;
                gb_single.Enabled = false;
            }
            else
            {
                gb_team.Enabled = false;
                gb_single.Enabled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_sound_off_Click(object sender, EventArgs e)
        {
            trb_sound.Value = 0;
            mp.Volume = 0;
            Properties.Settings.Default.volume = 0;
            Properties.Settings.Default.Save();
        }

        private void chb_team_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.team_game = chb_team.Checked;
            Properties.Settings.Default.Save();

            if (chb_team.Checked)
            {
                gb_team.Enabled = true;
                gb_single.Enabled = false;
            }
            else
            {
                gb_team.Enabled = false;
                gb_single.Enabled = true;
            }
        }

        private void trb_sound_Scroll(object sender, EventArgs e)
        {
            mp.Volume = trb_sound.Value / 100.0;
            Properties.Settings.Default.volume = trb_sound.Value;
            Properties.Settings.Default.Save();
        }

        private void btn_sound_on_Click(object sender, EventArgs e)
        {
            trb_sound.Value = 100;
            mp.Volume = 1;
            Properties.Settings.Default.volume = 100;
            Properties.Settings.Default.Save();
        }

        private void lbl_set_Click(object sender, EventArgs e)
        {

        }

        private void cb_attempts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_attempts.SelectedIndex == -1) return;

            Properties.Settings.Default.attempts = Convert.ToInt32(cb_attempts.SelectedItem);
            Properties.Settings.Default.Save();
        }

        private void cb_answertime_single_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_answertime_single.SelectedIndex == -1) return;

            Properties.Settings.Default.answertime_single = Convert.ToInt32(cb_answertime_single.SelectedItem);
            Properties.Settings.Default.Save();
        }

        private void chb_help_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.help = chb_help.Checked;
            Properties.Settings.Default.Save();
        }

        private void cb_gametime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_gametime.SelectedIndex == -1) return;

            Properties.Settings.Default.gametime = Convert.ToInt32(cb_gametime.SelectedItem);
            Properties.Settings.Default.Save();
        }
    }
}
