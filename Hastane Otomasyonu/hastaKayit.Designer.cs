namespace Hastane_Otomasyonu
{
    partial class hastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.btkayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(184, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 40);
            this.txtAd.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(183, 140);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(174, 40);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(184, 294);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(174, 40);
            this.txtsifre.TabIndex = 5;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(184, 191);
            this.msktc.Mask = "0000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(174, 40);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(184, 239);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(174, 40);
            this.msktel.TabIndex = 4;
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.Location = new System.Drawing.Point(183, 351);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(174, 41);
            this.combocinsiyet.TabIndex = 6;
            // 
            // btkayıtol
            // 
            this.btkayıtol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btkayıtol.Location = new System.Drawing.Point(184, 412);
            this.btkayıtol.Name = "btkayıtol";
            this.btkayıtol.Size = new System.Drawing.Size(173, 44);
            this.btkayıtol.TabIndex = 10;
            this.btkayıtol.Text = "Kayıt Ol";
            this.btkayıtol.UseVisualStyleBackColor = false;
            this.btkayıtol.Click += new System.EventHandler(this.btkayıtol_Click);
            // 
            // hastaKayit
            // 
            this.AcceptButton = this.btkayıtol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(460, 492);
            this.Controls.Add(this.btkayıtol);
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
            this.MaximizeBox = false;
            this.Name = "hastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.Button btkayıtol;
    }
}