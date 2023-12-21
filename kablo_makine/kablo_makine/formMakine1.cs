
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
using S7.Net.Types;

namespace kablo_makine
{
    public partial class formMakine1 : Form
    {
        Plc plc;
        bool buton_kontrol;
        public string yazı;
        string ipadres;
        public static CpuType Cpu;
        
        
        
        public formMakine1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            plc.Write("M27.3", false);
            MessageBox.Show("Makine Çalışmayı Durdurdu.");
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buton_kontrol == true)
            {

                var dwords = plc.Read(DataType.DataBlock, 1, 0, VarType.Real, 20,0);
                label4.Text = dwords.ToString();
       
               
         
         
                //   label6.Text = (plc.Read("M13.0")).ToString();
                //   label8.Text = (plc.Read("MW84")).ToString();
                //    label2.Text = (plc.Read("M27.3")).ToString();


                //          var lalll = plc.Read(DataType.DataBlock, 1, 0, VarType.String, 7);

                //          label14.Text = lalll.ToString();




                label8.Visible = true;

                label2.Visible =true;
                /*
                #region kablo kesit secimi
                int vardiyasecimi = Convert.ToInt32(plc.Read("MW200"));

                if (vardiyasecimi==0)
                {
                    label6.Text = "Kesit Seçilmedi.";
                }
                if (vardiyasecimi ==1)
                {
                    label6.Text = "0.5mm2";
                }
                else if (vardiyasecimi ==2)
                {
                    label6.Text = "1mm2";
                }
                else
                {
                    label6.Text = "1.5mm2";
                }
                #endregion


                #region vardiya secimi
                int vardiyasecim = Convert.ToInt32(plc.Read("MW202"));

                if (vardiyasecimi == 0)
                {
                    label14.Text = "Vardiya Seçilmedi.";
                }
                if (vardiyasecimi == 1)
                {
                    label14.Text = "7.30 - 15.30";
                }
                else if (vardiyasecimi == 2)
                {
                    label14.Text = "15.30 - 23.30";
                }
                else if (vardiyasecim == 3)
                {
                    label14.Text = "23.30 - 7.30";
                }
                else
                {
                    label14.Text = "7.30 - 17.30";
                }
                #endregion

                #region hatalar
                int hatakontrol = Convert.ToInt32(plc.Read("M29.3"));

                if (hatakontrol == 1)
                {
                    label19.Text = "Soket Arızası";
                }
                int hatakontrol2 = Convert.ToInt32(plc.Read("M29.4"));
                if (hatakontrol2==1)
                {
                    label19.Text = "Acil Basıldı";
                }
                int hatakontrol3 = Convert.ToInt32(plc.Read("M29.5"));
                if (hatakontrol3 == 1)
                {
                    label19.Text = "Kablo Sıkıştı";
                }
                int hatakontrol4 = Convert.ToInt32(plc.Read("M29.6"));
                if (hatakontrol4 == 1)
                {
                    label19.Text = "Sensör Arızası";
                }
                int hatakontrol5 = Convert.ToInt32(plc.Read("M29.7"));
                if (hatakontrol5 == 1)
                {
                    label19.Text = "Bıçak Değişimi";
                }
                int hatakontrol6 = Convert.ToInt32(plc.Read("M30.0"));
                if ( hatakontrol6 == 1)
                {
                    label19.Text = "Yeni Kablo";
                }
               int hatakontrol7 = Convert.ToInt32(plc.Read("M30.1"));
                if (hatakontrol7 == 1)
                {
                    label19.Text = "Yeni Soket";
                }
                int hatakontrol8 = Convert.ToInt32(plc.Read("M30.2"));
                if (hatakontrol8 == 1)
                {
                    label19.Text = "Hava Kaçağı";
                }
                int hatakontrol9 = Convert.ToInt32(plc.Read("M30.3"));
                if (hatakontrol9==1)
                {
                    label19.Text = "Temizlik";
                }
                #endregion
                */
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipadres = formAyarlar.ipadres1;
            plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
            plc.Open();
            buton_kontrol = true;
           
            if (plc.IsConnected)
            {
                MessageBox.Show("Bağlantı Başarılı."   );
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız.");
            }
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
