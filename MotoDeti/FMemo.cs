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
    public partial class FMemo : Form
    {
        FPdd f12 = new FPdd();
        public FMemo()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pdd_Click(object sender, EventArgs e)
        {
            f12.ShowDialog(this);
        }
    }
}
