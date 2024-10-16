using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class doktorPanel : Form
    {
        public doktorPanel()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSifre.Text = "";
            cmbBrans.Text = "";
            mskTc.Text = "";
            txtAd.TabIndex = 0;
        }
        void listele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tbl_doktor", con.baglanti());
            sqlDataAdapter.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void doktorPanel_Load(object sender, EventArgs e)
        {
            listele();
            //branşları combobox'a çekme
            SqlCommand sql = new SqlCommand("Select bransAd from tbl_brans", con.baglanti());
            SqlDataReader rd = sql.ExecuteReader();
            while (rd.Read())
            {

                cmbBrans.Items.Add(rd[0]);
            }
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlekle = new SqlCommand("insert into tbl_doktor (doktorAd,doktorSoyad,doktorBrans,doktorTC,doktorSifre) values (@p1,@p2,@p3,@p4,@p5)", con.baglanti());
            sqlekle.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sqlekle.Parameters.AddWithValue("@p3", cmbBrans.Text);
            sqlekle.Parameters.AddWithValue("@p4", mskTc.Text);
            sqlekle.Parameters.AddWithValue("@p5", txtSifre.Text);

            sqlekle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu");
            temizle();
            listele();
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlsil = new SqlCommand("delete  from tbl_doktor where doktorTC=@p1", con.baglanti());
            sqlsil.Parameters.AddWithValue("@p1", mskTc.Text);

            sqlsil.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Silinidi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlgüncelle = new SqlCommand("update tbl_doktor set doktorAd=@p1, doktorSoyad=@p2, doktorBrans=@p3, doktorSifre=@p4 where doktorTC=@p5 ", con.baglanti());
            sqlgüncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlgüncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sqlgüncelle.Parameters.AddWithValue("@p3", cmbBrans.Text);
            sqlgüncelle.Parameters.AddWithValue("@p4", txtSifre.Text);
            sqlgüncelle.Parameters.AddWithValue("@p5", mskTc.Text);

            sqlgüncelle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi");
            listele();
            temizle();

        }
    }
}
