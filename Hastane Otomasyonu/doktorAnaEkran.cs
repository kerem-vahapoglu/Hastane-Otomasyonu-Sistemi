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
    public partial class doktorAnaEkran : Form
    {
        public doktorAnaEkran()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        public string doktorTC;
        private void doktorAnaEkran_Load(object sender, EventArgs e)
        {
            //label doldurma
            lbldoktorTC.Text = doktorTC;

            SqlCommand sql = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorTC=@p1", con.baglanti());
            sql.Parameters.AddWithValue("@p1", lbldoktorTC.Text);

            SqlDataReader dr = sql.ExecuteReader();

            if (dr.Read())
            {
                tblAdSoyad.Text= dr[0] + " " + dr[1];
            }

            //datagrind doldurma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevuDoktor= '"+ tblAdSoyad.Text +"'",con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btBilgiGüncelle_Click(object sender, EventArgs e)
        {
            doktorBilgiGüncelle doktorBilgiGüncelle =new doktorBilgiGüncelle();
            doktorBilgiGüncelle.TC = lbldoktorTC.Text;
            doktorBilgiGüncelle.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; 
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btDuyuru_Click(object sender, EventArgs e)
        {
            frmduyurular frmduyurular = new frmduyurular();
            frmduyurular.Show();
        }

        private void bt_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
