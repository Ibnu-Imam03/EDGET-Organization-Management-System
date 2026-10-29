
using System.Data;
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class ClsMemberDataAccess
    {
        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                string query = @" SELECT M.MemberID, M.PersonID, P.FullName, P.Sex, P.TelegramUserName, M.StudentID, M.Department, M.YearOfStudy,
                        M.JoinDate, M.Status FROM Member AS M INNER JOIN Person AS P ON M.PersonID = P.PersonID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
