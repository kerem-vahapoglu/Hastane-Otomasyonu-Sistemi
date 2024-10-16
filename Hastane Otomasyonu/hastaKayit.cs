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
    public partial class hastaKayit : Form
    {
        public hastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        private void btkayıtol_Click(object sender, EventArgs e)
        {
            SqlCommand sqlekle = new SqlCommand("insert into tbl_hasta (hastaAd,hastaSoyad,hastaTC,hastaTelefon,hastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",con.baglanti());
            con.baglanti();

            sqlekle.Parameters.AddWithValue("@p1",txtAd.Text);
            sqlekle.Parameters.AddWithValue("@p2",txtsoyad.Text);
            sqlekle.Parameters.AddWithValue("@p3",msktc.Text);
            sqlekle.Parameters.AddWithValue("@p4",msktel.Text);
            sqlekle.Parameters.AddWithValue("@p5",txtsifre.Text);
            sqlekle.Parameters.AddWithValue("@p6",combocinsiyet.Text);
            sqlekle.ExecuteNonQuery();

            con.baglanti().Close();

            MessageBox.Show("Kaydızın başarılı bir şekilde oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
