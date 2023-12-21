namespace kablo_makine
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.graficContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grafic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.makine_1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.makine_2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.makine_3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.grafikTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.graficContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sersim | Simfer";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(33, 33);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.graficContainer);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 563);
            this.sidebar.TabIndex = 1;
            // 
            // graficContainer
            // 
            this.graficContainer.BackColor = System.Drawing.Color.Black;
            this.graficContainer.Controls.Add(this.panel5);
            this.graficContainer.Controls.Add(this.panel2);
            this.graficContainer.Controls.Add(this.panel9);
            this.graficContainer.Controls.Add(this.panel10);
            this.graficContainer.Location = new System.Drawing.Point(3, 3);
            this.graficContainer.Name = "graficContainer";
            this.graficContainer.Size = new System.Drawing.Size(191, 65);
            this.graficContainer.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grafic);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 56);
            this.panel5.TabIndex = 4;
            // 
            // grafic
            // 
            this.grafic.BackColor = System.Drawing.Color.Black;
            this.grafic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grafic.ForeColor = System.Drawing.Color.White;
            this.grafic.Image = ((System.Drawing.Image)(resources.GetObject("grafic.Image")));
            this.grafic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grafic.Location = new System.Drawing.Point(-12, -16);
            this.grafic.Name = "grafic";
            this.grafic.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.grafic.Size = new System.Drawing.Size(229, 79);
            this.grafic.TabIndex = 2;
            this.grafic.Text = "Grafikler";
            this.grafic.UseVisualStyleBackColor = false;
            this.grafic.Click += new System.EventHandler(this.grafic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 57);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-12, -9);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(229, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Günlük Üretim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button2);
            this.panel9.Location = new System.Drawing.Point(3, 128);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 57);
            this.panel9.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, -9);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(229, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Haftalık Üretim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button5);
            this.panel10.Location = new System.Drawing.Point(3, 191);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(197, 57);
            this.panel10.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-12, -9);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(229, 72);
            this.button5.TabIndex = 2;
            this.button5.Text = "Aylık Üretim";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Black;
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(3, 74);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(210, 56);
            this.menuContainer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menu);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 56);
            this.panel3.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-6, -19);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(241, 78);
            this.menu.TabIndex = 2;
            this.menu.Text = "Makineler";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.makine_1);
            this.panel6.Location = new System.Drawing.Point(3, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 56);
            this.panel6.TabIndex = 5;
            // 
            // makine_1
            // 
            this.makine_1.BackColor = System.Drawing.Color.Black;
            this.makine_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makine_1.ForeColor = System.Drawing.Color.White;
            this.makine_1.Image = ((System.Drawing.Image)(resources.GetObject("makine_1.Image")));
            this.makine_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makine_1.Location = new System.Drawing.Point(-12, -7);
            this.makine_1.Margin = new System.Windows.Forms.Padding(0);
            this.makine_1.Name = "makine_1";
            this.makine_1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.makine_1.Size = new System.Drawing.Size(241, 68);
            this.makine_1.TabIndex = 2;
            this.makine_1.Text = "Makine 1";
            this.makine_1.UseVisualStyleBackColor = false;
            this.makine_1.Click += new System.EventHandler(this.makine_1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.makine_2);
            this.panel7.Location = new System.Drawing.Point(3, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 56);
            this.panel7.TabIndex = 5;
            // 
            // makine_2
            // 
            this.makine_2.BackColor = System.Drawing.Color.Black;
            this.makine_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makine_2.ForeColor = System.Drawing.Color.White;
            this.makine_2.Image = ((System.Drawing.Image)(resources.GetObject("makine_2.Image")));
            this.makine_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makine_2.Location = new System.Drawing.Point(-12, -7);
            this.makine_2.Margin = new System.Windows.Forms.Padding(0);
            this.makine_2.Name = "makine_2";
            this.makine_2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.makine_2.Size = new System.Drawing.Size(241, 68);
            this.makine_2.TabIndex = 2;
            this.makine_2.Text = "Makine 2";
            this.makine_2.UseVisualStyleBackColor = false;
            this.makine_2.Click += new System.EventHandler(this.makine_2_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.makine_3);
            this.panel8.Location = new System.Drawing.Point(3, 189);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 56);
            this.panel8.TabIndex = 6;
            // 
            // makine_3
            // 
            this.makine_3.BackColor = System.Drawing.Color.Black;
            this.makine_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makine_3.ForeColor = System.Drawing.Color.White;
            this.makine_3.Image = ((System.Drawing.Image)(resources.GetObject("makine_3.Image")));
            this.makine_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makine_3.Location = new System.Drawing.Point(-12, -7);
            this.makine_3.Margin = new System.Windows.Forms.Padding(0);
            this.makine_3.Name = "makine_3";
            this.makine_3.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.makine_3.Size = new System.Drawing.Size(241, 68);
            this.makine_3.TabIndex = 2;
            this.makine_3.Text = "Makine 3";
            this.makine_3.UseVisualStyleBackColor = false;
            this.makine_3.Click += new System.EventHandler(this.makine_3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 56);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-12, -17);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(18, 5, 0, 0);
            this.button3.Size = new System.Drawing.Size(229, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ayarlar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button6);
            this.panel12.Location = new System.Drawing.Point(3, 198);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(197, 56);
            this.panel12.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-12, -17);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(18, 5, 0, 0);
            this.button6.Size = new System.Drawing.Size(229, 80);
            this.button6.TabIndex = 2;
            this.button6.Text = "Raporlar";
            this.button6.UseVisualStyleBackColor = false;
            
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button4);
            this.panel11.Location = new System.Drawing.Point(3, 260);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(197, 56);
            this.panel11.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-12, -17);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(18, 5, 0, 0);
            this.button4.Size = new System.Drawing.Size(229, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // grafikTransition
            // 
            this.grafikTransition.Interval = 10;
            this.grafikTransition.Tick += new System.EventHandler(this.grafikTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1010, 599);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.graficContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button grafic;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button makine_1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button makine_2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button makine_3;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.FlowLayoutPanel graficContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer grafikTransition;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button6;
    }
}

