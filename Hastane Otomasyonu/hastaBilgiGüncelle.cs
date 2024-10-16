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
    public partial class hastaBilgiGüncelle : Form
    {
        public hastaBilgiGüncelle()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        public string TCNo;

        private void hastaBilgiGüncelle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNo;
            SqlCommand komut= new SqlCommand("select * from tbl_hasta where hastaTC=@p1",con.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                txtAd.Text = dataReader[1].ToString();
                txtsoyad.Text = dataReader[2].ToString();
                msktel.Text = dataReader[4].ToString();
                txtsifre.Text = dataReader[5].ToString();
                combocinsiyet.Text = dataReader[6].ToString();
            }

            con.baglanti().Close();
            
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hasta set hastaAd=@p1, hastaSoyad=@p2, hastaTelefon=@p3, hastaSifre=@p4, hastaCinsiyet=@p5 where hastaTC=@p6", con.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktel.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", combocinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);

            komut2.ExecuteNonQuery();

            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

    }
}
