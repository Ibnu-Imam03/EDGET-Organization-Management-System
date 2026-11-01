
using System;
using System.Data;
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class ClsPersonDataAccess
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();


            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeopleWithPhones", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;

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

        public static int AddNewPerson(string FullName, string Sex, string TelegramUserName,
                                string Phone1, string Phone2, string Phone3, string Phone4)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_AddNewPerson", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = FullName;
                    cmd.Parameters.Add("@Sex", SqlDbType.NVarChar, 20).Value = Sex;
                    cmd.Parameters.Add("@TelegramUserName", SqlDbType.NVarChar, 100).Value =
                        string.IsNullOrWhiteSpace(TelegramUserName) ? (object)DBNull.Value : TelegramUserName;

                    cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar, 20).Value =
                        string.IsNullOrWhiteSpace(Phone1) ? (object)DBNull.Value : Phone1.Trim();

                    cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar, 20).Value =
                        string.IsNullOrWhiteSpace(Phone2) ? (object)DBNull.Value : Phone2.Trim();

                    cmd.Parameters.Add("@Phone3", SqlDbType.NVarChar, 20).Value =
                        string.IsNullOrWhiteSpace(Phone3) ? (object)DBNull.Value : Phone3.Trim();

                    cmd.Parameters.Add("@Phone4", SqlDbType.NVarChar, 20).Value =
                        string.IsNullOrWhiteSpace(Phone4) ? (object)DBNull.Value : Phone4.Trim();

                    connection.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool GetPersonByID(int ID, ref string FullName, ref string Sex, ref string TelegramUserName, ref string Phone1, ref string Phone2, ref string Phone3, ref string Phone4)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SP_GetPersonByID", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", ID);

                        conn.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FullName = reader["FullName"].ToString();
                                Sex = reader["Sex"].ToString();
                                TelegramUserName = reader["TelegramUserName"].ToString();

                                Phone1 = reader["Phone1"] == DBNull.Value ? "" : reader["Phone1"].ToString();
                                Phone2 = reader["Phone2"] == DBNull.Value ? "" : reader["Phone2"].ToString();
                                Phone3 = reader["Phone3"] == DBNull.Value ? "" : reader["Phone3"].ToString();
                                Phone4 = reader["Phone4"] == DBNull.Value ? "" : reader["Phone4"].ToString();

                                return true;
                            }

                            return false;
                        }
                    }
                }
            }
            catch (Exception)
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
