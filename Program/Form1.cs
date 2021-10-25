using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1791657z")
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


       
