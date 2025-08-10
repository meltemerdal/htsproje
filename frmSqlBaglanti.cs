using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class frmSqlBaglanti
    {
        internal string ConnectionString;
        string connectionString = "Server=CASPER\\SQLEXPRESS;Database=db_HastaneYonetim;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            return baglanti;
        }
    }
}
