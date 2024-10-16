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
    public partial class sekreterGiris : Form
    {
        public sekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();    

        private void bt_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekreterTC=@p1 and sekreterSifre=@p2",con.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.Read())
            {
                sekreterAnaEkran form = new sekreterAnaEkran();
                form.TC = maskedTextBox1.Text;  
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre Hatalı","Bilgi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);

            }    
        }
    }
}
