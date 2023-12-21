using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kablo_makine
{
    public partial class formAyarlar : Form
    {
         public static string ipadres1;
         public static string Cpu;
         
         
        public formAyarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipadres1 = textBox1.Text;
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("S71200 Seçildi.");
            }
            else if (checkBox2.Checked == true)
            {
             MessageBox.Show("S71500 Seçildi.");
            }
            if (checkBox1.Checked == false & checkBox2.Checked == false)
            {
             MessageBox.Show("Lütfen CpuType Seçiniz!");
             }
            else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
             MessageBox.Show("Başarısız! Lütfen Doğru Olanı Seçiniz!");
                button1.Enabled = false;
            }
            
            
                
            
        }

        private void formAyarlar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.0.25";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
