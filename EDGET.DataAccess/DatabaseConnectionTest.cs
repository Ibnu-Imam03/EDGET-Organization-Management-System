
using System;
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class DatabaseConnectionTest
    {
        public string TestConnection()
        {
            try
            {
                using (SqlConnection connection =
                    new DbConnectionFactory().GetConnection())
                {
                    connection.Open();

                    return "Database connection successful!";
                }
            }
            catch (Exception ex)
            {
                return "Database connection failed: " + ex.Message;
            }
        }
    }
}
