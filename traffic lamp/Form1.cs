using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_lamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı=Convert.ToInt32(label1.Text);
            sayı++;
            label1.Text=sayı.ToString();

            if (sayı == 30)
            {
                button2.BackColor = Color.Yellow;
            }
            if (sayı == 31)
            {
                button1.BackColor= Color.Gray;
                button2.BackColor= Color.Gray;
                button3.BackColor= Color.Green;

            }
            if(sayı == 70)
            {
                sayı = 0;
                label1.Text = sayı.ToString();
                button1.BackColor = Color.Red;
                button2.BackColor=Color.Gray;
                button3.BackColor = Color.Gray;

            }

        }
    }
}
