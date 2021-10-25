using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı;
        int dakika;
        int saat;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label2.Text);
            sayı++;
            label2.Text=sayı.ToString();

            if (sayı == 60)
            {
                sayı = 0;
                label2.Text = sayı.ToString();
                dakika++;
                label3.Text=dakika.ToString();

            }
            if(dakika == 60)
            {
                dakika = 0;
                label3.Text = dakika.ToString();
                saat++;
                label1.Text=saat.ToString();
            }
        }
    }
}
