using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ürünadet=0;
        int ürünfiyat;
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = label6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ürünadet++;
            
            textBox1.Text=ürünadet.ToString();
            ürünfiyat = ürünadet * ürünfiyat;
            textBox2.Text=ürünfiyat.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            listBox1.Items.Add(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            listBox2.Items.Add(textBox2.Text);
        }
    }
}
