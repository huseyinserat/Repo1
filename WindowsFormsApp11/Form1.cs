using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a=rastgele.Next(1,7);
            int b = rastgele.Next(1, 7);
            label4.Text = a.ToString();
            label3.Text = b.ToString();

            toplamben = toplamben + a + b;
            label15.Text=toplamben.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation= "C:\\Users\\husey\\OneDrive\\Masaüstü\\1.png";

            }
            if(a== 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\2.png";

            }
            if(a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\5.png";
            }
            if(a== 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\6.jpg";
            }
            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\2.png";
            }
            if(b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\3.jpg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\5.png";

            }
            if( b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\6.jpg";
            }
            if(toplamben>100 && toplamben > toplampc)
            {
                MessageBox.Show("oyunu Kullanıcı kazandı... ");
            }
            if(toplampc>100 && toplampc > toplamben)
            {
                MessageBox.Show("oyunu Pc kazandı...");
            }
            
            
             
       }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled=true;
            button2.Enabled=false;

            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            label9.Text = c.ToString();
            label10.Text = d.ToString();

            toplampc = toplampc + c + d;
            label16.Text=toplampc.ToString();
           

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\1.png";

            }
            if (c== 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\2.png";

            }
            if (c== 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\3.jpg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\6.jpg";
            }
            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\5.png";

            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\husey\\OneDrive\\Masaüstü\\6.jpg";
            }
            
            }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


        }
    }
}
