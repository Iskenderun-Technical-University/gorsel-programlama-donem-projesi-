using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Gazeteler : Form
    {
        public Gazeteler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.hurriyet.com.tr/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.sozcu.com.tr/");
      
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.star.com.tr/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mynet.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
