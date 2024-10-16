namespace Hastane_Otomasyonu
{
    partial class sekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterGiris));
            this.linkkayıtol = new System.Windows.Forms.LinkLabel();
            this.bt_girisyap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkkayıtol
            // 
            this.linkkayıtol.AutoSize = true;
            this.linkkayıtol.Location = new System.Drawing.Point(282, 403);
            this.linkkayıtol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkkayıtol.Name = "linkkayıtol";
            this.linkkayıtol.Size = new System.Drawing.Size(87, 28);
            this.linkkayıtol.TabIndex = 11;
            this.linkkayıtol.TabStop = true;
            this.linkkayıtol.Text = "Kayıt Ol";
            // 
            // bt_girisyap
            // 
            this.bt_girisyap.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_girisyap.Location = new System.Drawing.Point(242, 322);
            this.bt_girisyap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_girisyap.Name = "bt_girisyap";
            this.bt_girisyap.Size = new System.Drawing.Size(183, 53);
            this.bt_girisyap.TabIndex = 10;
            this.bt_girisyap.Text = "Giriş Yap";
            this.bt_girisyap.UseVisualStyleBackColor = false;
            this.bt_girisyap.Click += new System.EventHandler(this.bt_girisyap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 36);
            this.textBox1.TabIndex = 9;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(242, 158);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(170, 36);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // sekreterGiris
            // 
            this.AcceptButton = this.bt_girisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(608, 465);
            this.Controls.Add(this.linkkayıtol);
            this.Controls.Add(this.bt_girisyap);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sekreterGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkkayıtol;
        private System.Windows.Forms.Button bt_girisyap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}