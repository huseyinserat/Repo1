namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double t�rk�e, matematik, sosyal, fen;
            double ygs1;
            

            t�rk�e =Convert.ToDouble(textBox1.Text);
            matematik =Convert.ToDouble(textBox2.Text);
            sosyal = Convert.ToDouble(textBox3.Text);
            fen = Convert.ToDouble(textBox4.Text);

            ygs1 = 100.160(t�rk�e * 1.999) + (matematik * 3.998) + (sosyal * 1) + (fen * 2.999);
           label8.Text =ygs1.ToString();     
        }
    }
}