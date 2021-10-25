using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double türkçed, matematikd, sosyald, fend, türkçey, matematiky, sosyaly, feny, türkçen, matematikn, sosyaln, fenn;
            double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;

             türkçed = Convert.ToDouble(textBox1.Text);
             matematikd = Convert.ToDouble(textBox2.Text);
             sosyald= Convert.ToDouble(textBox3.Text);
             fend = Convert.ToDouble(textBox4.Text);
            türkçey= Convert.ToDouble(textBox5.Text);
            matematiky= Convert.ToDouble(textBox6.Text);
            sosyaly = Convert.ToDouble(textBox7.Text);
            feny = Convert.ToDouble(textBox8.Text);

            türkçen = türkçed - türkçey / 4;
            türkçen=Convert.ToDouble(textBox9.Text);
            matematikn = matematikd - matematiky / 4;
            matematikn=Convert.ToDouble(textBox10.Text);
            sosyaln = sosyald - sosyaly / 4;
            sosyaln = Convert.ToDouble(textBox11.Text);
            fenn = fend - feny / 4;
            fenn=Convert.ToDouble(textBox12.Text);




             ygs1 = 100.160+(türkçen * 1.999) + (matematikn * 3.998) + (sosyaln * 1) + (fenn * 2.999);
             label6.Text = ygs1.ToString();
             ygs2 = 100.160 + (türkçen * 1.999) + (matematikn * 2.999) + (sosyaln * 1) + (fenn * 3.998);
             label12.Text= ygs2.ToString();
             ygs3 = 100.160 + (türkçen * 3.998) + (matematikn  * 1.999) + (sosyaln * 2.999) + (fenn * 1);
             label13.Text= ygs3.ToString();
             ygs4 = 100.160+ (türkçen * 2.999) + (matematikn * 3.699) + (sosyaln * 3.998) + (fenn * 1);
             label14.Text=ygs4.ToString();
             ygs5 = 100.120+ (türkçen * 3.699) + (matematikn * 3.299) + (sosyaln * 1.999) + (fenn * 1);
             label15.Text= ygs5.ToString();
             ygs6 =100.120+ (türkçen * 3.299) + (matematikn * 1.699) + (sosyaln * 1) + (fenn* 1.999);
             label16.Text= ygs6.ToString();

            



        }
    }
}
