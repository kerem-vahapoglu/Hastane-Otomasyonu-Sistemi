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
    public partial class doktorGiris : Form
    {
        public doktorGiris()
        {
            InitializeComponent();
        }


        sqlbaglanti con = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from tbl_doktor where doktorTC = @p1 and doktorSifre=@p2", con.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@p2",textBox1.Text);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.Read())
            {
                doktorAnaEkran doktorAnaEkran = new doktorAnaEkran();
                doktorAnaEkran.doktorTC = maskedTextBox1.Text;
                doktorAnaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya şifre hatalı");
            }
        }
    }
}
