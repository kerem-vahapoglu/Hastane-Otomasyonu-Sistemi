namespace Hastane_Otomasyonu
{
    partial class doktorAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorAnaEkran));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldoktorTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchSikayet = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_cikis = new System.Windows.Forms.Button();
            this.btDuyuru = new System.Windows.Forms.Button();
            this.btBilgiGüncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbldoktorTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(332, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // tblAdSoyad
            // 
            this.tblAdSoyad.AutoSize = true;
            this.tblAdSoyad.Location = new System.Drawing.Point(162, 116);
            this.tblAdSoyad.Name = "tblAdSoyad";
            this.tblAdSoyad.Size = new System.Drawing.Size(67, 28);
            this.tblAdSoyad.TabIndex = 3;
            this.tblAdSoyad.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbldoktorTC
            // 
            this.lbldoktorTC.AutoSize = true;
            this.lbldoktorTC.Location = new System.Drawing.Point(149, 59);
            this.lbldoktorTC.Name = "lbldoktorTC";
            this.lbldoktorTC.Size = new System.Drawing.Size(156, 28);
            this.lbldoktorTC.TabIndex = 1;
            this.lbldoktorTC.Text = "000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchSikayet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(332, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgileri";
            // 
            // rchSikayet
            // 
            this.rchSikayet.Location = new System.Drawing.Point(96, 36);
            this.rchSikayet.Name = "rchSikayet";
            this.rchSikayet.Size = new System.Drawing.Size(220, 188);
            this.rchSikayet.TabIndex = 3;
            this.rchSikayet.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şikayet:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_cikis);
            this.groupBox3.Controls.Add(this.btDuyuru);
            this.groupBox3.Controls.Add(this.btBilgiGüncelle);
            this.groupBox3.Location = new System.Drawing.Point(12, 436);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(320, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı İşlemler";
            // 
            // bt_cikis
            // 
            this.bt_cikis.Location = new System.Drawing.Point(155, 91);
            this.bt_cikis.Name = "bt_cikis";
            this.bt_cikis.Size = new System.Drawing.Size(115, 39);
            this.bt_cikis.TabIndex = 0;
            this.bt_cikis.Text = "Çıkış";
            this.bt_cikis.UseVisualStyleBackColor = true;
            this.bt_cikis.Click += new System.EventHandler(this.bt_cikis_Click);
            // 
            // btDuyuru
            // 
            this.btDuyuru.Location = new System.Drawing.Point(19, 91);
            this.btDuyuru.Name = "btDuyuru";
            this.btDuyuru.Size = new System.Drawing.Size(115, 39);
            this.btDuyuru.TabIndex = 0;
            this.btDuyuru.Text = "Duyurular";
            this.btDuyuru.UseVisualStyleBackColor = true;
            this.btDuyuru.Click += new System.EventHandler(this.btDuyuru_Click);
            // 
            // btBilgiGüncelle
            // 
            this.btBilgiGüncelle.Location = new System.Drawing.Point(19, 36);
            this.btBilgiGüncelle.Name = "btBilgiGüncelle";
            this.btBilgiGüncelle.Size = new System.Drawing.Size(251, 39);
            this.btBilgiGüncelle.TabIndex = 0;
            this.btBilgiGüncelle.Text = "Bilgi Düzenle";
            this.btBilgiGüncelle.UseVisualStyleBackColor = true;
            this.btBilgiGüncelle.Click += new System.EventHandler(this.btBilgiGüncelle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(338, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 584);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 549);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // doktorAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1029, 606);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "doktorAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Ekranı";
            this.Load += new System.EventHandler(this.doktorAnaEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldoktorTC;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchSikayet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_cikis;
        private System.Windows.Forms.Button btDuyuru;
        private System.Windows.Forms.Button btBilgiGüncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}