using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puan_hesapla
{
    public partial class Form1 : Form
         {
   public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double türkçe, matematik, sosyal, fen;
            double ygs1;

            türkçe=Convert.ToDouble(textBox1.Text);
            matematik=Convert.ToDouble(textBox2.Text);
            sosyal=Convert.ToDouble(textBox3.Text);
            fen=Convert.ToDouble(textBox4.Text);

            ygs1 = 100*160(türkçe * 1.999) + (matematik * 3, 998) + (sosyal * 1) + (fen * 2.999);

        }
    }
}
