using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kim_milyoner_olmaz_ki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorunno = 0;
        int dogru = 0;
        int yanlış = 0;
        int süre = 30;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 30;
            label3.Text = süre.ToString();
            button5.Text = "İLERİ";
            sorunno++;
            label2.Text=sorunno.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (sorunno == 1)
            {
                richTextBox1.Text = "Türkiye nin Başkenti Neresidir?";
                button1.Text = "Ankara";
                button2.Text = "İstanbul";
                button3.Text = "Antalya";
                button4.Text = "İzmir";
                label10.Text = "Ankara";
            }
            if(sorunno == 2)
            {
                richTextBox1.Text = "Türkiye Kaç Bölgeye ayrılır?";
                button1.Text = "6";
                button2.Text = "7";
                button3.Text = "8";
                button4.Text = "9";
                label10.Text = "7";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled=false;
            timer1.Enabled=false;

            label9.Text = button1.Text;
            if (label9.Text == label10.Text)
            {
                dogru++;
                label7.Text=dogru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text=yanlış.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label9.Text=button2.Text;
            if(label9.Text == label10.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label9.Text = button3.Text;
            if( label9.Text == label10.Text)
            {
                dogru++;
                label7.Text=dogru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label9.Text = button4.Text;
            if (label9.Text == label10.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label3.Text);
            süre = süre - 1;
            label3.Text=süre.ToString();
            if (süre == 0)
            {
                timer1.Enabled=false;
                yanlış ++;
                label8.Text=yanlış.ToString();
            }
        }
    }
}
