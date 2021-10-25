using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/JOY_FM.mp3 ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://mpegpowerturk.listenpowerapp.com/powerturk/mpeg/icecast.audio";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/METRO_FM.mp3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com:80/;";
        }
    }
}
