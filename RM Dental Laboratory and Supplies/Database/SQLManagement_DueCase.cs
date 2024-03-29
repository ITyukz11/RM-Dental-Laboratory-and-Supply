using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Database
{
    public class SQLManagement_DueCase
    {
        SQLManagement SQL = new SQLManagement();
        public DataTable RetrieveDueCases()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQL.connection.Open();
                    string query = "SELECT " +
                        "d.full_name AS DentistFullName, " +
                        "c.due_time AS 'Due Time', " +
                        "c.record_date AS 'Record Date', " +
                        "c.record_time AS 'Record Time', " +
                        "c.patient_name AS 'Patient Name', " +
                        "c.status AS 'Status', " +
                        "c.[case] AS 'Case', " +
                        "c.description AS 'Description', " +
                        "c.remarks AS 'Remarks', " +
                        "c.provided AS 'Provided', " +
                        "u.full_name AS 'User Full Name' " +
                        "FROM dbo.cases c " +
                        "JOIN dbo.dentists d ON c.dentist_id = d.dentist_id " +
                        "JOIN dbo.users u ON c.user_id = u.users_id " +
                        "WHERE c.due_date >= GETDATE() " +  // Added condition for due date <= today's date
                        "ORDER BY c.case_id DESC;";


                SqlCommand command = new SqlCommand(query, SQL.connection);
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

    }
}
