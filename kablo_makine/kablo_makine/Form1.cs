using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace kablo_makine
{
    public partial class Form1 : Form
    {
       
        formMakine1 makine1;
        formMakine2 makine2;
        formMakine3 makine3;
        
       
        formAyarlar ayarlar;
        grafik1 gunluk;
        grafik2 haftalik;
        grafik3 aylik;

        
        public Form1()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        bool graficExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) 
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 250) 
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <=56)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 59)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();   
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

       

        

        private void makine_1_Click(object sender, EventArgs e)
        {
            if(makine1 == null)
            {
                makine1=new formMakine1();
                makine1.FormClosed += makine1_formclosed;
                makine1.MdiParent = this;
                makine1.Dock = DockStyle.Fill;
                makine1.Show();
                
            }
        }

        private void makine1_formclosed(object sender, FormClosedEventArgs e)
        {
            makine1 = null;
        }

        private void makine_2_Click(object sender, EventArgs e)
        {
            if(makine2 == null)
            {
                makine2 = new formMakine2();
                makine2.FormClosed += makine2_formclosed;
                makine2.MdiParent = this;
                makine2.Dock = DockStyle.Fill;
                makine2.Show();
            }
        }

        private void makine2_formclosed(object sender, FormClosedEventArgs e)
        {
            makine2 = null;
        }

        private void makine_3_Click(object sender, EventArgs e)
        {
            if(makine3 == null)
                makine3 = new formMakine3();
            makine3.FormClosed += makine3_formclosed;
            makine3.MdiParent = this;
            makine3.Dock = DockStyle.Fill;
            makine3.Show();
        }

        private void makine3_formclosed(object sender, FormClosedEventArgs e)
        {
            makine3=null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ayarlar == null)
            {
                ayarlar = new formAyarlar();
                ayarlar.FormClosed += ayarlar_formclosed;
                ayarlar.MdiParent = this;
                ayarlar.Dock = DockStyle.Fill;
                ayarlar.Show();

            }
        }

        private void ayarlar_formclosed(object sender, FormClosedEventArgs e)
        {
            ayarlar= null;
        }

        private void grafikTransition_Tick(object sender, EventArgs e)
        {
            if (graficExpand == false)
            {
                graficContainer.Height += 10;
                if (graficContainer.Height >= 250)
                {
                    grafikTransition.Stop();
                    graficExpand = true;
                }
            }
            else
            {
                graficContainer.Height -= 10;
                if (graficContainer.Height <= 56)
                {
                    grafikTransition.Stop();
                    graficExpand = false;
                }
            }
        }

        private void grafic_Click(object sender, EventArgs e)
        {
            grafikTransition.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (gunluk == null)
            {
                gunluk = new grafik1();
                gunluk.FormClosed += gunluk_formclosed;
                gunluk.MdiParent = this;
                gunluk.Dock = DockStyle.Fill;
                gunluk.Show();

            }
        }

        private void gunluk_formclosed(object sender, FormClosedEventArgs e)
        {
            gunluk = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (haftalik == null)
            {
                haftalik = new grafik2();
                haftalik.FormClosed += haftalik_formclosed;
                haftalik.MdiParent = this;
                haftalik.Dock = DockStyle.Fill;
                haftalik.Show();

            }
        }

        private void haftalik_formclosed(object sender, FormClosedEventArgs e)
        {
           haftalik=null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (aylik == null)
            {
                aylik = new grafik3();
                aylik.FormClosed += aylik_formclosed;
                aylik.MdiParent = this;
                aylik.Dock = DockStyle.Fill;
                aylik.Show();

            }
        }

        private void aylik_formclosed(object sender, FormClosedEventArgs e)
        {
            aylik =null;
        }

     /*   private void button6_Click(object sender, EventArgs e)
        {
            if(rapor == null)
            {
                rapor= new formRapor();
                rapor.FormClosed += rapor_formclosed;
                rapor.MdiParent = this;
                rapor.Dock = DockStyle.Fill;
                rapor.Show();
            }
        }*/

     /*   private void rapor_formclosed(object sender, FormClosedEventArgs e)
        {
            rapor= null;
        } */
    }
}
