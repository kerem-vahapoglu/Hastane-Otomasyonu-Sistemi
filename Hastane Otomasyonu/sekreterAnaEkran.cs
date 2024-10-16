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
using System.Data.Common;

namespace Hastane_Otomasyonu
{
    public partial class sekreterAnaEkran : Form
    {

        public sekreterAnaEkran()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        public string TC, adSoyad;

        private void btkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand sqlekle = new SqlCommand("insert into tbl_randevu (randevuTarih,randevuSaat,randevuBrans,randevuDoktor) values(@p1,@p2,@p3,@p4)",con.baglanti());
            sqlekle.Parameters.AddWithValue("@p1",mskTarih.Text);
            sqlekle.Parameters.AddWithValue("@p2",mskSaat.Text);
            sqlekle.Parameters.AddWithValue("@p3",cmbBrans.Text);
            sqlekle.Parameters.AddWithValue("@p4",cmbDoktor.Text);

            sqlekle.ExecuteNonQuery();

            MessageBox.Show("Randevu Oluşturuldu");
            con.baglanti().Close();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Text = "";
            cmbDoktor.Items.Clear();

            SqlCommand sql2 = new SqlCommand("select (doktorAd + ' ' + doktorSoyad) as 'Doktorlar' from tbl_doktor where doktorBrans=@p1", con.baglanti());
            sql2.Parameters.AddWithValue("@p1", cmbBrans.Text);

            SqlDataReader rd2 = sql2.ExecuteReader();
            while (rd2.Read())
            {
                cmbDoktor.Items.Add(rd2[0]);
            }

        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand sqlduyuru = new SqlCommand("insert into tbl_duyuru (duyuruMetni) values (@p1)", con.baglanti());
            sqlduyuru.Parameters.AddWithValue("@p1",richTextBox1.Text);

            sqlduyuru.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");

            richTextBox1.Text = "";
        }

        private void bt_branslar_Click(object sender, EventArgs e)
        {
            bransPaneli bransPaneli = new bransPaneli();
            bransPaneli.Show();
        }

        private void bt_doktorlar_Click(object sender, EventArgs e)
        {
            doktorPanel doktorPanel = new doktorPanel();
            doktorPanel.Show();
        }

        private void bt_randevular_Click(object sender, EventArgs e)
        {
            randevuListesi randevuListesi = new randevuListesi();
            randevuListesi.Show();
        }

        private void bt_duyuru_Click(object sender, EventArgs e)
        {
            frmduyurular frmduyurular = new frmduyurular();
            frmduyurular.Show();
        }

        private void sekreterAnaEkran_Load(object sender, EventArgs e)
        {
            //tc ve ad soyad verilerini çekme
            lblTC.Text = TC;
            SqlCommand sqlCommand1 = new SqlCommand("select sekreterAdSoyad from tbl_sekreter where sekreterTc= @p1", con.baglanti());
            sqlCommand1.Parameters.AddWithValue("@p1", TC);

            SqlDataReader dataReader = sqlCommand1.ExecuteReader();
            while (dataReader.Read())
            {
                lblAdsoyad.Text = dataReader[0].ToString();
            }
            con.baglanti().Close();

            //branşları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_brans", con.baglanti());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorları çekme

            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select (doktorAd + ' ' + doktorSoyad) as 'Doktorlar', doktorBrans from tbl_doktor", con.baglanti());
            sqlDataAdapter.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşları combobox'a çekme
            SqlCommand sql = new SqlCommand("Select bransAd from tbl_brans", con.baglanti());
            SqlDataReader rd = sql.ExecuteReader();
            while (rd.Read())
            {

                cmbBrans.Items.Add(rd[0]);
            }


        }
    }
}
