namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int rmpuan=0;
        int lvp=0;
        int psg=0;
        int bm=0;

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a=rastgele.Next(0,5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label10.Text=a.ToString();
            label9.Text=b.ToString();
            label8.Text=c.ToString();
            label7.Text=d.ToString();
            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label9.Text))
            {
                rmpuan = rmpuan + 3;
                label14.Text=rmpuan.ToString();
            }
            if(Convert.ToInt32(label9.Text)>Convert.ToInt32(label10.Text))
            {
                lvp=lvp + 3;
                label13.Text=lvp.ToString();
            }
            if(Convert.ToInt32(label9.Text)==Convert.ToInt32(label10.Text))
            {
                rmpuan = rmpuan + 1;
                label14.Text = rmpuan.ToString();
                lvp = lvp + 1;
                label13.Text = lvp.ToString();
            }
            if(Convert.ToInt32(label8.Text)>Convert.ToInt32(label7.Text))
            {
                psg=psg + 3;
                label11.Text=psg.ToString();
            }
            if(Convert.ToInt32(label7.Text)>Convert.ToInt32(label8.Text))
            {
                bm=bm + 3;
                label12.Text=bm.ToString();
           }
            if(Convert.ToInt32(label8.Text)==Convert.ToInt32(label7.Text))
            {
                psg=psg+1;
                label11.Text = psg.ToString();
                bm=bm+1;
                label12.Text=bm.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           button2.Enabled=false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label22.Text = a.ToString();
            label21.Text = b.ToString();
            label17.Text = c.ToString();
            label15.Text = d.ToString();

            if(Convert.ToInt32(label22.Text)>Convert.ToInt32(label21.Text))
            {
                rmpuan = rmpuan + 3;
                label14.Text=rmpuan.ToString();
            }
            if(Convert.ToInt32(label21.Text)>Convert.ToInt32(label22.Text))
            {
                psg=psg + 3;
                label11.Text=psg.ToString();
            }
            if(Convert.ToInt32(label22.Text)==Convert.ToInt32(label21.Text))
            {
                rmpuan=rmpuan + 1;
                label14.Text = rmpuan.ToString();

                psg=psg + 1;
                label11.Text = psg.ToString();

            }
          if(Convert.ToInt32(label17.Text)>Convert.ToInt32(label15.Text))
            {
                lvp=lvp + 3;
                label13.Text=lvp.ToString();
            }
          if(Convert.ToInt32(label15.Text)>Convert.ToInt32(label17.Text))
            {
                bm=bm + 3;
                label12.Text=bm.ToString();
            }
          if(Convert.ToInt32(label17.Text)==Convert.ToInt32(label15.Text))
            {
                lvp=lvp+1;
                label13.Text=lvp.ToString();
                bm=bm + 1;
                label12.Text=bm.ToString();
            }
                 
               

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled=false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label32.Text = a.ToString();
            label31.Text = b.ToString();
            label30.Text = c.ToString();
            label29.Text = d.ToString();

            if(Convert.ToInt32(label32.Text)>Convert.ToInt32(label31.Text))
            {
                bm=bm + 3;
                label12.Text = bm.ToString();

           }
            if(Convert.ToInt32(label31.Text)>Convert.ToInt32(label32.Text))
            {
                rmpuan=rmpuan + 3;
                label14.Text=rmpuan.ToString();
            }
             if(Convert.ToInt32(label32.Text) == Convert.ToInt32(label31.Text))
            {
              bm = bm + 1;
                label12.Text = bm.ToString();
                rmpuan = rmpuan + 1;
                label14.Text = rmpuan.ToString();
            }
            if(Convert.ToInt32(label30.Text) > Convert.ToInt32(label29.Text))
            { lvp = lvp + 3;
                label13.Text = lvp.ToString();
            }
            if(Convert.ToInt32(label29.Text)>Convert.ToInt32(label30.Text))
            {
                psg=psg + 3;
                label11.Text=psg.ToString();
            }
            if(Convert.ToInt32(label30.Text)==Convert.ToInt32(label29.Text))
            {
                lvp=lvp + 1;
                label13.Text=lvp.ToString();
                psg=psg + 1;
                label11.Text = psg.ToString();

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}