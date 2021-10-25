using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şampiyonlar_ligi
{
    public partial class Form1 : Form
    {
        List<takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            takim yenitakim = null;
            takimlar = new List<takim>();

            yenitakim = new takim("bayern münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Willarreal", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Athletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Man City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new takim("PSG", "Fransa");
            takimlar.Add(yenitakim);

            yenitakim = new takim("İnter", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Lille", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Sporting Lizbon", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Beşiktaş", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Dinamo Kiev", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yenitakim);

            yenitakim = new takim("Sheriff", "Moldova");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Young Boys", "İsvecre");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Benfica", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Milan", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Atalanta", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Malmö", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Zenit", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new takim("Wolfsburg", "Almanya");
            takimlar.Add(yenitakim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = ayniulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as takim);
                        if (ayniulkedentakimvar)
                        break;
                }
                if (ayniulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as takim);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as takim);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as takim);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as takim);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as takim);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as takim);



                }
                else
                {
                    j--;
                }
            }
        }
        private bool ayniulkedentakimvarmi(ListBox grup,takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                takim gruptakim = grup.Items[i] as takim;
                if(gruptakim.TeamCountry==takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele=new Random();
            List<int>secilentakimlar=new List<int>();
            for(int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim=rastgele.Next(0,takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for(int i = 0;i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    listBox1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if(i < 16)
                {
                    listBox2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    listBox3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    listBox4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(listBox1);
            torbalar.Add(listBox2);
            torbalar.Add(listBox3);
            torbalar.Add(listBox4);

            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
                gruplar.Add(listBox8);
            gruplar.Add(listBox9);
            gruplar.Add(listBox10);
                gruplar.Add(listBox11);
                    

    
        }
    }
}

