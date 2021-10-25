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

namespace Kullanıcı_Girişi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\husey\\OneDrive\\Masaüstü\\Database21.accdb");

        private void verılerıgoruntule()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = ("select*from tablo1");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["E-Posta adresi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["id"].ToString());
                ekle.SubItems.Add(oku["şifre"].ToString());

                listView1.Items.Add(ekle);




            }
            baglantı.Close();
        }
    }
}
