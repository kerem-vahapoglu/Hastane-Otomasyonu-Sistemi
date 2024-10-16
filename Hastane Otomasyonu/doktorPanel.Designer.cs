namespace Hastane_Otomasyonu
{
    partial class doktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorPanel));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.btgüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(132, 223);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(149, 36);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(132, 181);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(149, 36);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(132, 137);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(149, 36);
            this.cmbBrans.TabIndex = 4;
            // 
            // bt_ekle
            // 
            this.bt_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ekle.Location = new System.Drawing.Point(132, 279);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(149, 36);
            this.bt_ekle.TabIndex = 5;
            this.bt_ekle.Text = "Ekle";
            this.bt_ekle.UseVisualStyleBackColor = false;
            this.bt_ekle.Click += new System.EventHandler(this.bt_ekle_Click);
            // 
            // btSil
            // 
            this.btSil.BackColor = System.Drawing.Color.Red;
            this.btSil.Location = new System.Drawing.Point(132, 321);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(149, 36);
            this.btSil.TabIndex = 5;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // btgüncelle
            // 
            this.btgüncelle.BackColor = System.Drawing.Color.Yellow;
            this.btgüncelle.Location = new System.Drawing.Point(132, 363);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(149, 36);
            this.btgüncelle.TabIndex = 5;
            this.btgüncelle.Text = "Güncelle";
            this.btgüncelle.UseVisualStyleBackColor = false;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 353);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(132, 46);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 36);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(132, 89);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // doktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1113, 452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btgüncelle);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.bt_ekle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "doktorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor İşlem Paneli";
            this.Load += new System.EventHandler(this.doktorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}