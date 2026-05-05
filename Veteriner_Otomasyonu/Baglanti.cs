using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Veteriner_Otomasyonu
{
    public class Baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.; Initial Catalog=VETERİNER_OTOMASYONU; Integrated Security=True; TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
