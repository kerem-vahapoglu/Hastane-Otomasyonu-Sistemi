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
    public partial class hastaAnaEkran : Form
    {
        public hastaAnaEkran()
        {
            InitializeComponent();
        }

        public string TC;

        sqlbaglanti con = new sqlbaglanti();

        private void hastaAnaEkran_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;


            //TC bilgisi üzerinden ad soyad çekmes
            SqlCommand komut = new SqlCommand("select hastaAd,hastaSoyad from tbl_hasta where hastaTC= @p1",con.baglanti());

            komut.Parameters.AddWithValue("@p1",lblTC.Text);

            SqlDataReader rd = komut.ExecuteReader();

            while (rd.Read()) 
            {
                lblAdSoyad.Text = rd[0] +" " + rd[1];                  
            
            }

            con.baglanti().Close();

            //randevu geçmişini listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevu where hastaTC = "+TC,con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları combobox'a ekleme

            SqlCommand komut2 = new SqlCommand("select bransAd from tbl_brans", con.baglanti());
            SqlDataReader dataReader = komut2.ExecuteReader();
            while (dataReader.Read()) 
            {
                cmbbrans.Items.Add(dataReader[0]);
            }



        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktorları combobox'a ekleme
            cmbdoktor.Items.Clear();
            cmbdoktor.Text = string.Empty;
            SqlCommand komut3 = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorBrans=@p1", con.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevuBrans='" +cmbbrans.Text + "'" + "and randevuDoktor='"+cmbdoktor.Text+"' and  randevuDurum=0",con.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkbilgigüncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastaBilgiGüncelle form = new hastaBilgiGüncelle();
            form.TCNo=lblTC.Text;
            form.Show();
           
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand sqlguncele = new SqlCommand("update tbl_randevu set randevuDurum=1, hastaTC=@p1, hastaSikayet=@p2 where randevuId=@p3",con.baglanti());
            sqlguncele.Parameters.AddWithValue("@p1",lblTC.Text);
            sqlguncele.Parameters.AddWithValue("@p2", rcksikayet.Text);
            sqlguncele.Parameters.AddWithValue("@p3",txtid.Text);

            sqlguncele.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }
    }
}
