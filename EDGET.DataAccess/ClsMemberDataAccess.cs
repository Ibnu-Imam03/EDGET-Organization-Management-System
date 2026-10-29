
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace EDGET.DataAccess
{
    public class ClsMemberDataAccess
    {
        // READ: Get all members.
        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                string query = @"
                    SELECT M.MemberID, M.PersonID, P.FullName,P.Sex, P.TelegramUserName,M.StudentID, M.Department, M.YearOfStudy,M.JoinDate, M.Status
                    FROM Member AS M INNER JOIN Person AS P  ON M.PersonID = P.PersonID   ORDER BY M.MemberID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // READ: Get one member by MemberID.
        public static bool GetMemberByID(int memberID, ref int personID, ref string studentID, ref string department, ref int yearOfStudy, ref DateTime joinDate, ref bool status)
        {
            using (SqlConnection connection = DbConnectionFactory.GetConnection())
            {
                string query = @"SELECT PersonID, StudentID, Department, YearOfStudy, JoinDate, Status FROM Member WHERE MemberID = @MemberID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        personID = Convert.ToInt32(reader["PersonID"]);
                        studentID = reader["StudentID"].ToString();
                        department = reader["Department"].ToString();
                        yearOfStudy = Convert.ToInt32(reader["YearOfStudy"]);
                        joinDate = Convert.ToDateTime(reader["JoinDate"]);
                        status = Convert.ToBoolean(reader["Status"]);

                        return true;
                    }
                }
            }
        }
        // CREATE: Add a new member for an existing Person.
        // Returns the newly generated MemberID.
        public static int AddMember( int personID, string studentID, string department, int yearOfStudy, DateTime joinDate, bool status)
        {

            try
            {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                {
                    string query = @"
                    INSERT INTO Member(PersonID, StudentID, Department,YearOfStudy, JoinDate, Status)
                    VALUES(@PersonID, @StudentID, @Department,@YearOfStudy, @JoinDate, @Status);

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@PersonID", SqlDbType.Int).Value =
                            personID;

                        command.Parameters.Add("@StudentID", SqlDbType.VarChar, 30).Value =
                            studentID;

                        command.Parameters.Add("@Department", SqlDbType.NVarChar, 100).Value =
                            department;

                        command.Parameters.Add("@YearOfStudy", SqlDbType.Int).Value =
                            yearOfStudy;

                        command.Parameters.Add("@JoinDate", SqlDbType.Date).Value =
                            joinDate.Date;

                        command.Parameters.Add("@Status", SqlDbType.Bit).Value =
                            status;

                        connection.Open();

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }catch (Exception)
            {
                return -1;
            }
        }

        // UPDATE: Modify an existing member.
        public static bool UpdateMember(int memberID, int personID, string studentID, string department, int yearOfStudy, DateTime joinDate, bool status)
        {

            try {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                {
                    string query = @"
                    UPDATE Member
                    SET PersonID = @PersonID,StudentID = @StudentID,Department = @Department,YearOfStudy = @YearOfStudy,JoinDate = @JoinDate,
                        Status = @Status  WHERE MemberID = @MemberID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                        command.Parameters.Add("@PersonID", SqlDbType.Int).Value = personID;

                        command.Parameters.Add("@StudentID", SqlDbType.VarChar, 30).Value = studentID;

                        command.Parameters.Add("@Department", SqlDbType.NVarChar, 100).Value = department;

                        command.Parameters.Add("@YearOfStudy", SqlDbType.Int).Value = yearOfStudy;

                        command.Parameters.Add("@JoinDate", SqlDbType.Date).Value = joinDate.Date;

                        command.Parameters.Add("@Status", SqlDbType.Bit).Value = status;

                        connection.Open();

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }catch (Exception ex)
            {
                return false;
            }
         }

        // DELETE: Remove a member record, not the Person record.
        public static bool DeleteMember(int memberID)
        {
            try {
                using (SqlConnection connection = DbConnectionFactory.GetConnection())
                {
                    string query = @"DELETE FROM Member  WHERE MemberID = @MemberID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@MemberID", SqlDbType.Int).Value =memberID;

                        connection.Open();

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }catch(Exception ex)
            {
                return false;
            }
         }

        public static bool IsMemberexisted(int memberID)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.GetConnection())
                {
                    string query = "SELECT 1 FROM Member   WHERE MemberID = @memberID ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberID", memberID);

                        conn.Open();

                        object resalte = cmd.ExecuteScalar();

                        if (resalte != null)
                        {
                            return true;
                        }
                        else 
                        {
                            return false;
                        }
                    }
                }
            }catch(Exception ex) { return false; }
        }


    }
}
