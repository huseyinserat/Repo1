﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IP_Adresi_ogrenme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteadi=Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ıp = siteadi.AddressList;
                textBox2.Text = ıp[0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("boyle bir site bulunamadı");
            }

            {

                throw;
            }
        }
    }
}
