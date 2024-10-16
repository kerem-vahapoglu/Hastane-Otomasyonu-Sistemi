using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class bransPaneli : Form
    {
        public bransPaneli()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti(); 
        
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtAd.Text = "";
            txtID.Text = "";
        }

        private void bransPaneli_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlekle = new SqlCommand("insert into tbl_brans (bransAd) values (@p1)",con.baglanti());
            sqlekle.Parameters.AddWithValue("@p1", txtAd.Text);

            sqlekle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Branş eklendi");
            listele();
            temizle();
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlsil = new SqlCommand("delete from tbl_brans where bransId=@p1", con.baglanti());
            sqlsil.Parameters.AddWithValue("@p1",txtID.Text);

            sqlsil.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Branş Silindi");
            listele();
            temizle();

;       }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlgncelle = new SqlCommand("update tbl_brans set bransAd=@p1 where bransId=@p2", con.baglanti());
            sqlgncelle.Parameters.AddWithValue("@p1",txtAd.Text);
            sqlgncelle.Parameters.AddWithValue("@p2",txtID.Text);

            sqlgncelle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
