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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text+"-"+comboBox2.Text);
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(textBox3.Text);
            MessageBox.Show("kayıt Başarılı");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();

            Form1 frm=new Form1();
            frm.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
