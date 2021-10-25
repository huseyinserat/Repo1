using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        oledbConnection baglantý=new OLEDBConnection();
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.Show();
            this.Hide();
        }
    }
}