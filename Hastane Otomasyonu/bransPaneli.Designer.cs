namespace Hastane_Otomasyonu
{
    partial class bransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bransPaneli));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btgüncelle = new System.Windows.Forms.Button();
            this.btSil = new System.Windows.Forms.Button();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 36);
            this.txtAd.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 36);
            this.txtID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "İd:";
            // 
            // btgüncelle
            // 
            this.btgüncelle.BackColor = System.Drawing.Color.Yellow;
            this.btgüncelle.Location = new System.Drawing.Point(125, 231);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(149, 36);
            this.btgüncelle.TabIndex = 7;
            this.btgüncelle.Text = "Güncelle";
            this.btgüncelle.UseVisualStyleBackColor = false;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // btSil
            // 
            this.btSil.BackColor = System.Drawing.Color.Red;
            this.btSil.Location = new System.Drawing.Point(125, 189);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(149, 36);
            this.btSil.TabIndex = 8;
            this.btSil.Text = "Sil";
            this.btSil.UseVisualStyleBackColor = false;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // bt_ekle
            // 
            this.bt_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ekle.Location = new System.Drawing.Point(125, 147);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(149, 36);
            this.bt_ekle.TabIndex = 9;
            this.bt_ekle.Text = "Ekle";
            this.bt_ekle.UseVisualStyleBackColor = false;
            this.bt_ekle.Click += new System.EventHandler(this.bt_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 219);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(661, 305);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btgüncelle);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.bt_ekle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "bransPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bransPaneli";
            this.Load += new System.EventHandler(this.bransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}