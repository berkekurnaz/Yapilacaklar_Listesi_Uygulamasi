namespace KisiselYapilacaklarApp.Screens
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükYapılacaklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakGunlukEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakGunlukListele = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakGunlukHepsiniListele = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalıkYapılacaklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakHaftalikEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakHaftalikListele = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakHaftalikHepsiniListele = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkYapılacaklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakAylikEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakAylikListele = new System.Windows.Forms.ToolStripMenuItem();
            this.stripYapilacakAylikHepsiniListele = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNotEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.stripNotListele = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.stripCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWeekCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMonthCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.günlükYapılacaklarToolStripMenuItem,
            this.haftalıkYapılacaklarToolStripMenuItem,
            this.aylıkYapılacaklarToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.stripAyarlar,
            this.stripCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // günlükYapılacaklarToolStripMenuItem
            // 
            this.günlükYapılacaklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripYapilacakGunlukEkle,
            this.stripYapilacakGunlukListele,
            this.stripYapilacakGunlukHepsiniListele});
            this.günlükYapılacaklarToolStripMenuItem.Name = "günlükYapılacaklarToolStripMenuItem";
            this.günlükYapılacaklarToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.günlükYapılacaklarToolStripMenuItem.Text = "Günlük Yapılacaklar";
            // 
            // stripYapilacakGunlukEkle
            // 
            this.stripYapilacakGunlukEkle.Name = "stripYapilacakGunlukEkle";
            this.stripYapilacakGunlukEkle.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakGunlukEkle.Text = "Yeni Ekle";
            this.stripYapilacakGunlukEkle.Click += new System.EventHandler(this.stripYapilacakGunlukEkle_Click);
            // 
            // stripYapilacakGunlukListele
            // 
            this.stripYapilacakGunlukListele.Name = "stripYapilacakGunlukListele";
            this.stripYapilacakGunlukListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakGunlukListele.Text = "Listele";
            this.stripYapilacakGunlukListele.Click += new System.EventHandler(this.stripYapilacakGunlukListele_Click);
            // 
            // stripYapilacakGunlukHepsiniListele
            // 
            this.stripYapilacakGunlukHepsiniListele.Name = "stripYapilacakGunlukHepsiniListele";
            this.stripYapilacakGunlukHepsiniListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakGunlukHepsiniListele.Text = "Hepsini Listele";
            this.stripYapilacakGunlukHepsiniListele.Click += new System.EventHandler(this.stripYapilacakGunlukHepsiniListele_Click);
            // 
            // haftalıkYapılacaklarToolStripMenuItem
            // 
            this.haftalıkYapılacaklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripYapilacakHaftalikEkle,
            this.stripYapilacakHaftalikListele,
            this.stripYapilacakHaftalikHepsiniListele});
            this.haftalıkYapılacaklarToolStripMenuItem.Name = "haftalıkYapılacaklarToolStripMenuItem";
            this.haftalıkYapılacaklarToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.haftalıkYapılacaklarToolStripMenuItem.Text = "Haftalık Yapılacaklar";
            // 
            // stripYapilacakHaftalikEkle
            // 
            this.stripYapilacakHaftalikEkle.Name = "stripYapilacakHaftalikEkle";
            this.stripYapilacakHaftalikEkle.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakHaftalikEkle.Text = "Yeni Ekle";
            this.stripYapilacakHaftalikEkle.Click += new System.EventHandler(this.stripYapilacakHaftalikEkle_Click);
            // 
            // stripYapilacakHaftalikListele
            // 
            this.stripYapilacakHaftalikListele.Name = "stripYapilacakHaftalikListele";
            this.stripYapilacakHaftalikListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakHaftalikListele.Text = "Listele";
            this.stripYapilacakHaftalikListele.Click += new System.EventHandler(this.stripYapilacakHaftalikListele_Click);
            // 
            // stripYapilacakHaftalikHepsiniListele
            // 
            this.stripYapilacakHaftalikHepsiniListele.Name = "stripYapilacakHaftalikHepsiniListele";
            this.stripYapilacakHaftalikHepsiniListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakHaftalikHepsiniListele.Text = "Hepsini Listele";
            this.stripYapilacakHaftalikHepsiniListele.Click += new System.EventHandler(this.stripYapilacakHaftalikHepsiniListele_Click);
            // 
            // aylıkYapılacaklarToolStripMenuItem
            // 
            this.aylıkYapılacaklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripYapilacakAylikEkle,
            this.stripYapilacakAylikListele,
            this.stripYapilacakAylikHepsiniListele});
            this.aylıkYapılacaklarToolStripMenuItem.Name = "aylıkYapılacaklarToolStripMenuItem";
            this.aylıkYapılacaklarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.aylıkYapılacaklarToolStripMenuItem.Text = "Aylık Yapılacaklar";
            // 
            // stripYapilacakAylikEkle
            // 
            this.stripYapilacakAylikEkle.Name = "stripYapilacakAylikEkle";
            this.stripYapilacakAylikEkle.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakAylikEkle.Text = "Yeni Ekle";
            this.stripYapilacakAylikEkle.Click += new System.EventHandler(this.stripYapilacakAylikEkle_Click);
            // 
            // stripYapilacakAylikListele
            // 
            this.stripYapilacakAylikListele.Name = "stripYapilacakAylikListele";
            this.stripYapilacakAylikListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakAylikListele.Text = "Listele";
            this.stripYapilacakAylikListele.Click += new System.EventHandler(this.stripYapilacakAylikListele_Click);
            // 
            // stripYapilacakAylikHepsiniListele
            // 
            this.stripYapilacakAylikHepsiniListele.Name = "stripYapilacakAylikHepsiniListele";
            this.stripYapilacakAylikHepsiniListele.Size = new System.Drawing.Size(180, 26);
            this.stripYapilacakAylikHepsiniListele.Text = "Hepsini Listele";
            this.stripYapilacakAylikHepsiniListele.Click += new System.EventHandler(this.stripYapilacakAylikHepsiniListele_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNotEkle,
            this.stripNotListele});
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.notlarToolStripMenuItem.Text = "Notlar";
            // 
            // stripNotEkle
            // 
            this.stripNotEkle.Name = "stripNotEkle";
            this.stripNotEkle.Size = new System.Drawing.Size(142, 26);
            this.stripNotEkle.Text = "Yeni Ekle";
            this.stripNotEkle.Click += new System.EventHandler(this.stripNotEkle_Click);
            // 
            // stripNotListele
            // 
            this.stripNotListele.Name = "stripNotListele";
            this.stripNotListele.Size = new System.Drawing.Size(142, 26);
            this.stripNotListele.Text = "Listele";
            this.stripNotListele.Click += new System.EventHandler(this.stripNotListele_Click);
            // 
            // stripAyarlar
            // 
            this.stripAyarlar.Name = "stripAyarlar";
            this.stripAyarlar.Size = new System.Drawing.Size(68, 24);
            this.stripAyarlar.Text = "Ayarlar";
            this.stripAyarlar.Click += new System.EventHandler(this.stripAyarlar_Click);
            // 
            // stripCikisYap
            // 
            this.stripCikisYap.Name = "stripCikisYap";
            this.stripCikisYap.Size = new System.Drawing.Size(79, 24);
            this.stripCikisYap.Text = "Çıkış Yap";
            this.stripCikisYap.Click += new System.EventHandler(this.stripCikisYap_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTodayCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.Location = new System.Drawing.Point(3, 58);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(192, 23);
            this.lblTodayCount.TabIndex = 1;
            this.lblTodayCount.Text = "0";
            this.lblTodayCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugün Yapılacak Sayısı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblWeekCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(236, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // lblWeekCount
            // 
            this.lblWeekCount.Location = new System.Drawing.Point(3, 58);
            this.lblWeekCount.Name = "lblWeekCount";
            this.lblWeekCount.Size = new System.Drawing.Size(192, 23);
            this.lblWeekCount.TabIndex = 1;
            this.lblWeekCount.Text = "0";
            this.lblWeekCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bu Hafta Yapılacak Sayısı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblMonthCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(460, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // lblMonthCount
            // 
            this.lblMonthCount.Location = new System.Drawing.Point(3, 58);
            this.lblMonthCount.Name = "lblMonthCount";
            this.lblMonthCount.Size = new System.Drawing.Size(192, 23);
            this.lblMonthCount.TabIndex = 1;
            this.lblMonthCount.Text = "0";
            this.lblMonthCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bu Ay Yapılacak Sayısı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblAllCount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(684, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // lblAllCount
            // 
            this.lblAllCount.Location = new System.Drawing.Point(3, 58);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(192, 23);
            this.lblAllCount.TabIndex = 1;
            this.lblAllCount.Text = "0";
            this.lblAllCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Girilen Kayıt";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bugün Yapılacaklar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 292);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(304, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 329);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bu Hafta Yapılacaklar";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(7, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 292);
            this.listBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(600, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 329);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bu Ay Yapılacaklar";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(9, 30);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(271, 292);
            this.listBox3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(12, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 67);
            this.panel5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tarih";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 592);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişisel Yapılacaklar Uygulaması";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükYapılacaklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakGunlukEkle;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakGunlukListele;
        private System.Windows.Forms.ToolStripMenuItem haftalıkYapılacaklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakHaftalikEkle;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakHaftalikListele;
        private System.Windows.Forms.ToolStripMenuItem notlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripNotEkle;
        private System.Windows.Forms.ToolStripMenuItem stripNotListele;
        private System.Windows.Forms.ToolStripMenuItem stripAyarlar;
        private System.Windows.Forms.ToolStripMenuItem stripCikisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTodayCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWeekCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMonthCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakGunlukHepsiniListele;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakHaftalikHepsiniListele;
        private System.Windows.Forms.ToolStripMenuItem aylıkYapılacaklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakAylikEkle;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakAylikListele;
        private System.Windows.Forms.ToolStripMenuItem stripYapilacakAylikHepsiniListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}