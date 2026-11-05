
using System;
using System.Data;
using System.Data.SqlClient;

namespace EDGET.DataAccess
{
    public class ClsFamilyDataAccess
    {
        // ADD NEW FAMILY
        public static int AddNewFamily(int PersonID, string FamilyName, string Address, string Situation)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_AddNewFamily", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
                    cmd.Parameters.Add("@FamilyName", SqlDbType.NVarChar, 100).Value = FamilyName;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value = Address;
                    cmd.Parameters.Add("@Situation", SqlDbType.NVarChar, 500).Value = Situation;

                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                }
            }
            catch (SqlException)
            {
                return -1;
            }

            return -1;
        }

        // GET FAMILY BY ID
        public static bool GetFamilyByID(int ID, ref int PersonID, ref string FamilyName,
                                         ref string Address, ref string Situation)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_GetFamilyByID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FamilyID", SqlDbType.Int).Value = ID;

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            FamilyName = reader["FamilyName"].ToString();
                            Address = reader["Address"].ToString();
                            Situation = reader["Situation"].ToString();

                            return true;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }

            return false;
        }

        // GET ALL FAMILIES
        public static DataTable GetAllFamilies()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_GetAllFamilies", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        // UPDATE FAMILY
        public static bool UpdateFamily(int FamilyID, int PersonID, string FamilyName,
                                        string Address, string Situation)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_UpdateFamily", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FamilyID", SqlDbType.Int).Value = FamilyID;
                    cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
                    cmd.Parameters.Add("@FamilyName", SqlDbType.NVarChar, 100).Value = FamilyName;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value = Address;
                    cmd.Parameters.Add("@Situation", SqlDbType.NVarChar, 500).Value = Situation;

                    connection.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // DELETE FAMILY
        public static  bool DeleteFamily(int FamilyID)
        {
            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SP_DeleteFamily", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FamilyID", SqlDbType.Int).Value = FamilyID;

                    connection.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
