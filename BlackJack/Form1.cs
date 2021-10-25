using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int sayac=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a1, a2, toplam;

           a1=rastgele.Next(1,11);
            a2 = rastgele.Next(1, 11);
            toplam=a1+ a2;

            label1.Text = a1.ToString();
            label2.Text = a2.ToString();
            label6.Text = toplam.ToString();
    }
}
