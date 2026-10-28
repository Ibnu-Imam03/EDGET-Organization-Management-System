
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString =
            "Server=.;Database=EDGET_CharityDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
