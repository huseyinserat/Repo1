namespace Blackjack2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Random rastgele =new Random();
         int sayac=0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;

            if(sayac==1)

            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label6.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text=a3.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label6.Text=toplam.ToString();
            }
            if(sayac == 3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                label4.Text=a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label6.Text=toplam.ToString();
            }
            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\kupa1.png";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\8.png";
            }
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = ":C\\Users\\husey\\OneDrive\\Masaüstü\\ugulamalar\\Yeni klasör\\10.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;

            label10.Text = b1.ToString();
            label11.Text = b2.ToString();
            label8.Text=toplam.ToString();

            if (toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                label12.Text=b3.ToString();
                toplam=toplam+ b3;
                label8.Text = toplam.ToString();
            }
            if(toplam < 16)
            {
                int b4;
                b4= rastgele.Next(1,11);
                label13.Text=b4.ToString();

                toplam = toplam + b4;
                label8.Text=toplam.ToString();

            }
            
        }
    }
}