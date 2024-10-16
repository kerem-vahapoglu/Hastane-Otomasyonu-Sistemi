namespace Hastane_Otomasyonu
{
    partial class sekreterAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterAnaEkran));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_randevular = new System.Windows.Forms.Button();
            this.bt_doktorlar = new System.Windows.Forms.Button();
            this.bt_branslar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btkaydet = new System.Windows.Forms.Button();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblAdsoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_duyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_duyuru);
            this.groupBox1.Controls.Add(this.bt_randevular);
            this.groupBox1.Controls.Add(this.bt_doktorlar);
            this.groupBox1.Controls.Add(this.bt_branslar);
            this.groupBox1.Location = new System.Drawing.Point(0, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hızlı İşlemler";
            // 
            // bt_randevular
            // 
            this.bt_randevular.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_randevular.ForeColor = System.Drawing.Color.Black;
            this.bt_randevular.Location = new System.Drawing.Point(288, 49);
            this.bt_randevular.Name = "bt_randevular";
            this.bt_randevular.Size = new System.Drawing.Size(178, 46);
            this.bt_randevular.TabIndex = 1;
            this.bt_randevular.Text = "Randevu Liste";
            this.bt_randevular.UseVisualStyleBackColor = false;
            this.bt_randevular.Click += new System.EventHandler(this.bt_randevular_Click);
            // 
            // bt_doktorlar
            // 
            this.bt_doktorlar.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_doktorlar.ForeColor = System.Drawing.Color.Black;
            this.bt_doktorlar.Location = new System.Drawing.Point(146, 49);
            this.bt_doktorlar.Name = "bt_doktorlar";
            this.bt_doktorlar.Size = new System.Drawing.Size(148, 46);
            this.bt_doktorlar.TabIndex = 1;
            this.bt_doktorlar.Text = "Doktor Paneli";
            this.bt_doktorlar.UseVisualStyleBackColor = false;
            this.bt_doktorlar.Click += new System.EventHandler(this.bt_doktorlar_Click);
            // 
            // bt_branslar
            // 
            this.bt_branslar.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_branslar.ForeColor = System.Drawing.Color.Black;
            this.bt_branslar.Location = new System.Drawing.Point(0, 49);
            this.bt_branslar.Name = "bt_branslar";
            this.bt_branslar.Size = new System.Drawing.Size(148, 46);
            this.bt_branslar.TabIndex = 1;
            this.bt_branslar.Text = "Branş Paneli";
            this.bt_branslar.UseVisualStyleBackColor = false;
            this.bt_branslar.Click += new System.EventHandler(this.bt_branslar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(54, 194);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(187, 44);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = false;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btkaydet);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(325, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 467);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btkaydet
            // 
            this.btkaydet.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btkaydet.Location = new System.Drawing.Point(108, 371);
            this.btkaydet.Name = "btkaydet";
            this.btkaydet.Size = new System.Drawing.Size(146, 35);
            this.btkaydet.TabIndex = 10;
            this.btkaydet.Text = "Kaydet";
            this.btkaydet.UseVisualStyleBackColor = false;
            this.btkaydet.Click += new System.EventHandler(this.btkaydet_Click);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(118, 231);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(136, 36);
            this.cmbDoktor.TabIndex = 9;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(118, 186);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(136, 36);
            this.cmbBrans.TabIndex = 9;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(118, 280);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(136, 36);
            this.mskTC.TabIndex = 8;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(118, 135);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(136, 36);
            this.mskSaat.TabIndex = 8;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(118, 83);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(136, 36);
            this.mskTarih.TabIndex = 8;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 36);
            this.txtId.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, 333);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 32);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Durum";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hasta TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "İd:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(653, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 233);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(323, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(653, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 365);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(598, 330);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblAdsoyad);
            this.groupBox6.Controls.Add(this.lblTC);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 200);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sekreter Bilgi";
            // 
            // lblAdsoyad
            // 
            this.lblAdsoyad.AutoSize = true;
            this.lblAdsoyad.Location = new System.Drawing.Point(145, 107);
            this.lblAdsoyad.Name = "lblAdsoyad";
            this.lblAdsoyad.Size = new System.Drawing.Size(67, 28);
            this.lblAdsoyad.TabIndex = 0;
            this.lblAdsoyad.Text = "NULL";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(145, 60);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(96, 28);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "0000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1017, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_duyuru
            // 
            this.bt_duyuru.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_duyuru.Location = new System.Drawing.Point(472, 49);
            this.bt_duyuru.Name = "bt_duyuru";
            this.bt_duyuru.Size = new System.Drawing.Size(158, 46);
            this.bt_duyuru.TabIndex = 2;
            this.bt_duyuru.Text = "Duyurular";
            this.bt_duyuru.UseVisualStyleBackColor = false;
            this.bt_duyuru.Click += new System.EventHandler(this.bt_duyuru_Click);
            // 
            // sekreterAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1269, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sekreterAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sekreterAnaEkran";
            this.Load += new System.EventHandler(this.sekreterAnaEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblAdsoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_randevular;
        private System.Windows.Forms.Button bt_doktorlar;
        private System.Windows.Forms.Button bt_branslar;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btkaydet;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_duyuru;
    }
}