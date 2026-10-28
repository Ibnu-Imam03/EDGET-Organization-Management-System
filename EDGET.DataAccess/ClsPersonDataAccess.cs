
using System.Data;
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class ClsPersonDataAccess
    {
        public static DataTable GetAllPeople()
        {
            string query = "SELECT * FROM Person";

            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
