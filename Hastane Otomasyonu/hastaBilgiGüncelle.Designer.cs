namespace Hastane_Otomasyonu
{
    partial class hastaBilgiGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastaBilgiGüncelle));
            this.btgüncelle = new System.Windows.Forms.Button();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btgüncelle
            // 
            this.btgüncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btgüncelle.Location = new System.Drawing.Point(201, 423);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(245, 44);
            this.btgüncelle.TabIndex = 18;
            this.btgüncelle.Text = "Bilgileri Güncelle\r\n";
            this.btgüncelle.UseVisualStyleBackColor = false;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.Location = new System.Drawing.Point(236, 346);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(174, 41);
            this.combocinsiyet.TabIndex = 6;
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(236, 237);
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(174, 40);
            this.msktel.TabIndex = 4;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(236, 189);
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(174, 40);
            this.msktc.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(236, 292);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(174, 40);
            this.txtsifre.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(236, 133);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(174, 40);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(236, 79);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 40);
            this.txtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad:";
            // 
            // hastaBilgiGüncelle
            // 
            this.AcceptButton = this.btgüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(546, 532);
            this.Controls.Add(this.btgüncelle);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "hastaBilgiGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgileri Güncelleme";
            this.Load += new System.EventHandler(this.hastaBilgiGüncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}