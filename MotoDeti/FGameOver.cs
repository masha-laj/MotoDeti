using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FGameOver : Form
    {
        private string team = "";
        public string Team
        {
            get => team;
            set
            {
                team = value;
                RefreshTeamLbl();
            }
        }
        public FGameOver()
        {
            InitializeComponent();
        }

        private void RefreshTeamLbl()
        {
            lbl_team.Text = Team;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btn_revenge_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void FGameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
