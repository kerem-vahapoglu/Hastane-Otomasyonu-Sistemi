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
    public partial class doktorBilgiGüncelle : Form
    {
        public doktorBilgiGüncelle()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();
        public string TC;

        private void doktorBilgiGüncelle_Load(object sender, EventArgs e)
        {
            msktc.Text = TC;

            SqlCommand sql = new SqlCommand("select * from tbl_doktor where doktorTC=@p1", con.baglanti());
            sql.Parameters.AddWithValue("@p1",msktc.Text);

            SqlDataReader dr = sql.ExecuteReader();

            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }

        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("update tbl_doktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p4 where doktorTC=@p5",con.baglanti());
            sql.Parameters.AddWithValue("p1",txtAd.Text);   
            sql.Parameters.AddWithValue("p2",txtsoyad.Text);   
            sql.Parameters.AddWithValue("p3",cmbbrans.Text);   
            sql.Parameters.AddWithValue("p4",txtsifre.Text);  
            sql.Parameters.AddWithValue("p5",msktc.Text);  
            

            sql.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
