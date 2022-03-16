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
    public partial class SplashScreen : Form
    {
        private List<Image> imgs = new List<Image>()
        {
            Properties.Resources.motodeti,
            Properties.Resources.ghosts,
            Properties.Resources.buynye,
            Properties.Resources.polugora
        };
        private int imgcount = 0;
        private int imgindex = 0;

        FMainMenu mm;
        public SplashScreen()
        {
            InitializeComponent();
            imgcount = imgs.Count;

            Next();
        }

        private void Next()
        {
            if (imgindex >= imgcount)
            {
                Hide();
                mm = new FMainMenu();
                mm.Show();
                timer1.Stop();
            } else
                pictureBox1.BackgroundImage = imgs[imgindex++];
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Next();
        }
    }
}
