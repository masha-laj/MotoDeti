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
    public partial class FMenuMap : Form
    {
        public FMenuMap()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_set_Click(object sender, EventArgs e)
        {

        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            var Form = new FTop();
            Form.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
