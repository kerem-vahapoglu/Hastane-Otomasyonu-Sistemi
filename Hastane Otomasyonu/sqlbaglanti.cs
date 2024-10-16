using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LKTU092;Initial Catalog=HastaneSistemi;Integrated Security=True;TrustServerCertificate=True;");
            baglan.Open();
            return baglan;
        }
    }
}
