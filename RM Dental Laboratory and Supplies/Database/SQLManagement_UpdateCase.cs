using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM_Dental_Laboratory_and_Supplies.Global.UpdateCase;

namespace RM_Dental_Laboratory_and_Supplies.Database
{
    public class SQLManagement_UpdateCase
    {
        SQLManagement SQL = new SQLManagement();

        public DataTable RetrieveCases(string filterColumn, string searchQuery)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQL.connection.Open();
                string query = $"SELECT * FROM dbo.cases WHERE {filterColumn} LIKE @searchQuery";
                SqlCommand command = new SqlCommand(query, SQL.connection);
                command.Parameters.AddWithValue("@searchQuery", $"%{searchQuery}%");
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SQL.connection.Close();
            }

            return dataTable;
        }

        //public DataTable RetrieveCases()
        //{
        //    DataTable dataTable = new DataTable();

        //    try
        //    {
        //        SQL.connection.Open();
        //        string query = "SELECT " +
        //            "case_id AS 'Case ID', " +
        //            "case_type_code AS 'Case Type/Code', " +
        //            "patient_name AS 'Patient Name', " +
        //            "record_date AS 'Record Date', " +
        //            "record_time AS 'Record Time', " +
        //            "[case] AS 'Case', " +
        //            "description AS 'Description', " +
        //            "due_date AS 'Due Date', " +
        //            "due_time AS 'Due Time', " +
        //            "status AS 'Status', " +
        //            "remarks AS 'Remarks', " +
        //            "provided AS 'Provided', " +
        //            "dentist_id AS 'Dentist ID' FROM dbo.cases ORDER BY case_id DESC";

        //        SqlCommand command = new SqlCommand(query, SQL.connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            dataTable.Load(reader);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        SQL.connection.Close();
        //    }

        //    return dataTable;
        //}

        public CaseData RetrieveCases()
        {
            CaseData caseData = new CaseData();

            try
            {
                SQL.connection.Open();
                string query = "SELECT " +
                    "case_id AS 'Case ID', " +
                    "case_type_code AS 'Case Type/Code', " +
                    "patient_name AS 'Patient Name', " +
                    "record_date AS 'Record Date', " +
                    "record_time AS 'Record Time', " +
                    "[case] AS 'Case', " +
                    "description AS 'Description', " +
                    "due_date AS 'Due Date', " +
                    "due_time AS 'Due Time', " +
                    "status AS 'Status', " +
                    "remarks AS 'Remarks', " +
                    "provided AS 'Provided', " +
                    "dentist_id AS 'Dentist ID' FROM dbo.cases ORDER BY case_id DESC";

                SqlCommand command = new SqlCommand(query, SQL.connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    caseData.Cases = new DataTable();
                    caseData.Cases.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ErrorZ: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SQL.connection.Close();
            }

            return caseData;
        }

            public bool DeleteCase(string caseId)
            {
                try
                {
                    // Define the SQL query to delete a case with the specified caseId
                    string query = "DELETE FROM dbo.cases WHERE case_id = @CaseID";

                 // Open the connection
                    SQL.connection.Open();
                       

                        // Create a SqlCommand object with the delete query
                        using (SqlCommand command = new SqlCommand(query, SQL.connection))
                        {
                            // Add parameters to the query to prevent SQL injection
                            command.Parameters.AddWithValue("@CaseID", caseId);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if any rows were affected (case was deleted)
                            if (rowsAffected > 0)
                            {
                                // Case was deleted successfully
                                return true;
                            }
                            else
                            {
                                // No rows were affected, meaning the case with the specified ID was not found
                                return false;
                            }
                        }
                   
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the deletion process
                    Console.WriteLine("Error deleting case: " + ex.Message);
                    return false;
                }finally { SQL.connection.Close(); }
            }

        public string GetDentistName(int dentist_id)
        {
            string dentistName = "";
            try
            {
                SQL.connection.Open();
                string query = "SELECT full_name FROM dbo.dentists WHERE dentist_id = @dentistId";
                SqlCommand command = new SqlCommand(query, SQL.connection);
                command.Parameters.AddWithValue("@dentistId", dentist_id);

                // Execute the query and retrieve the dentist name
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    dentistName = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SQL.connection.Close();
            }
            return dentistName;
        }

        public Global.UpdateCase.CaseData RetrieveCaseById(string caseId)
        {
            Global.UpdateCase.CaseData caseData = null;
            try
            {
              
                    SQL.connection.Open();
                    string query = @"
                SELECT c.*, u.username 
                FROM dbo.cases c 
                INNER JOIN dbo.users u ON c.user_id = u.users_id
                WHERE c.case_id = @caseId";
                    using (SqlCommand command = new SqlCommand(query, SQL.connection))
                    {
                        command.Parameters.AddWithValue("@caseId", caseId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming CaseData is a class with properties matching the column names in the cases table
                                caseData = new Global.UpdateCase.CaseData
                                {
                                    CaseId = reader["case_id"].ToString(),
                                    PatientName = reader["patient_name"].ToString(),
                                    CaseTypeCode = reader["case_type_code"].ToString(),
                                    TimeCreated = reader["record_time"].ToString(), // Adjust type as per your database schema
                                    DateCreated = reader["record_date"].ToString(), // Adjust type as per your database schema
                                    Status = reader["status"].ToString(),
                                    Case = reader["case"].ToString(),
                                    Description = reader["description"].ToString(),
                                    DueTime = reader["due_time"].ToString(),
                                    DueDate = reader["due_date"].ToString(),
                                    Remarks = reader["remarks"].ToString(),
                                    Provided = reader["provided"].ToString(),
                                    Username = reader["username"].ToString() // Add the username property
                                };
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving case data: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SQL.connection.Close(); }
            return caseData;
        }


        public bool UpdateCase(string case_type_code, string patient_name, DateTime record_date, TimeSpan record_time, string status,
string case_, string description, DateTime due_date, TimeSpan due_time, string remarks, string provided, byte[] image, int dentist_id, int user_id)
        {
            try
            {
                SQL.connection.Open();
                string query = @"INSERT INTO dbo.cases (case_type_code, patient_name, record_date, record_time, status, [case], description, due_date, due_time, remarks, provided, image, dentist_id, user_id) 
                    VALUES (@case_type_code,  @patient_name, @record_date, @record_time, @status, @case, @description, @due_date, @due_time, @remarks, @provided, @image, @dentist_id, @user_id)";
                SqlCommand command = new SqlCommand(query, SQL.connection);

                command.Parameters.AddWithValue("@case_type_code", case_type_code);
                command.Parameters.AddWithValue("@patient_name", patient_name);
                command.Parameters.AddWithValue("@record_date", record_date);
                command.Parameters.AddWithValue("@record_time", record_time);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@case", case_);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@due_date", due_date);
                command.Parameters.AddWithValue("@due_time", due_time);
                command.Parameters.AddWithValue("@remarks", remarks);
                command.Parameters.AddWithValue("@provided", provided);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@dentist_id", dentist_id);
                command.Parameters.AddWithValue("@user_id", user_id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully added new case", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                SQL.connection.Close();
            }
        }
    }
}
