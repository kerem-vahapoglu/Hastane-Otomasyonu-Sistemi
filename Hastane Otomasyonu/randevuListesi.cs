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
    public partial class randevuListesi : Form
    {
        public randevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglanti con = new sqlbaglanti();

        private void randevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu",con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
        
        }
    }
}
