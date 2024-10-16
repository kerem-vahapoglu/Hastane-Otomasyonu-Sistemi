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
    public partial class hastaGiris : Form
    {
        public hastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastaKayit hastaKayit = new hastaKayit();
            hastaKayit.Show();

        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select * from tbl_hasta where hastaTC=@p1 and hastaSifre=@p2", con.baglanti());
            sql.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            sql.Parameters.AddWithValue("@p2", textBox1.Text);

            SqlDataReader rd = sql.ExecuteReader();

            if (rd.Read())
            {
                hastaAnaEkran fr = new hastaAnaEkran();
                fr.TC = maskedTextBox1.Text;    
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Bilgi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);   
            }

            con.baglanti().Close();
        }
    }
}
