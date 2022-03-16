using System;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FLevelTip : Form
    {
        public FLevelTip()
        {
            InitializeComponent();
        }

        public void SetTip(string tip)
        {
            lbl_tip.Text = tip;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
