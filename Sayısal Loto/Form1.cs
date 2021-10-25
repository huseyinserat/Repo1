using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            int rastgele;
            int sayac=0;
            int[] sayılar=new int[7];

            while (sayac < 7)
            {
                rastgele = r.Next(1, 90);
                if (Array.IndexOf(sayılar, rastgele) == -1)
                {
                    sayılar[sayac] = rastgele;
                    sayac++;
                }
            }
            Array.Sort(sayılar);
            label1.Text=sayılar[0].ToString();
            label2.Text = sayılar[1].ToString();
            label3.Text = sayılar[2].ToString();
            label4.Text = sayılar[3].ToString();
            label5.Text = sayılar[4].ToString();
            label6.Text = sayılar[5].ToString();
            label7.Text = sayılar[6].ToString();


        }
        }
    }

