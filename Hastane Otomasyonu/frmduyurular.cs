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
    public partial class frmduyurular : Form
    {
        public frmduyurular()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();


        private void frmduyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_duyuru",con.baglanti());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
