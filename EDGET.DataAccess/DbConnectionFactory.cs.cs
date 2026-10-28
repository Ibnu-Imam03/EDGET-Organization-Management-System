
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    
    public static class DbConnectionFactory
    {

        private readonly static string _connectionString =
            "Server=.;Database=EDGET_CharityDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            
            return new SqlConnection(_connectionString);
        }
    }
}
