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

namespace MotoDeti
{
    public partial class FSingle : Form
    {
        FRegistration f4 = new FRegistration();
        FContinue f5 = new FContinue();
        FTop f6 = new FTop();
        public FSingle()
        {
            InitializeComponent();
        }

        private void FSingle_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            f4.ShowDialog(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            f5.ShowDialog(this);
        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            f6.ShowDialog(this);
        }
    }
}
