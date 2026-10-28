
using System;
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


        public static bool UpdatePerson(int ID, string FullName, string Sex, string TelegramUserName)
        {
            string query = @"UPDATE Person SET FullName = @FullName, Sex = @Sex, TelegramUserName = @TelegramUserName WHERE PersonID = @ID";

            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Best practice: specify parameter types and sizes
                        // to match the actual SQL Server column definitions.
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = FullName;
                        command.Parameters.Add("@Sex", SqlDbType.NVarChar, 20).Value = Sex;
                        command.Parameters.Add("@TelegramUserName", SqlDbType.NVarChar, 100).Value = TelegramUserName;

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        // True means at least one row was affected.
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Best practice: don't silently hide database errors.
                return false;
            }
        }


        public static bool DeletePerson(int ID)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.GetConnection())
                {
                    string query = "DELETE Person WHERE PersonID =@ID";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        conn.Open();

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch 
            {
                return false; 
            }
        }

        public static int AddNewPerson(string FullName, string Sex, string TelegramUserName)
        {
            int ID = -1;

            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                string query = @" INSERT INTO Person (FullName, Sex, TelegramUserName) VALUES (@FullName, @Sex, @TelegramUserName);
                                  SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = FullName;
                    cmd.Parameters.Add("@Sex", SqlDbType.NVarChar, 20).Value = Sex;
                    cmd.Parameters.Add("@TelegramUserName", SqlDbType.NVarChar, 100).Value = TelegramUserName;

                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        ID = Convert.ToInt32(result);
                    }

                    return ID;
                }
            }
        }


        public static bool GetPersonByID(int ID,ref string FullName,ref string Sex,ref string TelegramUserName){
            try
            {
                using (SqlConnection conn = DbConnectionFactory.GetConnection())
                {
                    string query = @"SELECT FullName, Sex, TelegramUserName FROM Person WHERE PersonID = @ID";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                        conn.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FullName = reader["FullName"].ToString();
                                Sex = reader["Sex"].ToString();
                                TelegramUserName = reader["TelegramUserName"].ToString();

                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsPersonExist(int ID)
        {
            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                string query = "SELECT 1 FROM Person WHERE PersonID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    connection.Open();

                    return command.ExecuteScalar() != null;
                }
            }
        }

    }
}
