using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class frmSqlBaglanti
    {
        string connectionString = "Server=CASPER\\SQLEXPRESS;Database=db_HastaneYonetim;User Id=sa;Password=SeninSifren;";


        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            return baglanti;
        }
    }
}
