using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kullanıcı1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        readonly OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bilgiler.accdb");

        private void Verılerıgoruntule()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand
            {
                CommandText = ("select*from bilgiler")
            };
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem
                {
                    Text = oku["Ad"].ToString()
                };
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["E-Posta adresi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Kullanıcı Adı"].ToString());
                ekle.SubItems.Add(oku["Şifre"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into tablo1(Ad,Soyad,E-Posta adersi,Cinsiyet,Kullanıcı Adı,Şifre)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString()+"')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            Verılerıgoruntule();
        }
    }
}
