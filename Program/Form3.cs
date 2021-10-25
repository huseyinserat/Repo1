using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Program
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        StreamWriter yaz;
        private void Form3_Load(object sender, EventArgs e)
        {
            
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }

        }


        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.AppendText("Ben" + richTextBox2.Text + "\n");
                yaz = new StreamWriter(ag);
                yaz.WriteLine(label4.Text + ":" + richTextBox2.Text);
                yaz.Flush();
                richTextBox2.Text = "";
            }
        

        }
        }
        }

         

        

        
            
        


