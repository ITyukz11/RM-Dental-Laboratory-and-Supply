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
        public class SQLManagement_Dentists
        {
            SQLManagement SQL = new SQLManagement();
            public DentistsData RetrieveDentists()
            {
                DentistsData dentistsData = new DentistsData();

                try
                {
                    SQL.connection.Open();
                    string query = "SELECT " +
                    "dentist_id AS 'Dentist ID', " +
                    "full_name AS 'Full Name', " +
                    "address AS 'Address', " +
                    "contact_num AS 'Contact Number', " +
                    "email_address AS 'Email Address' " +
                    "FROM dbo.dentists ORDER BY dentist_id DESC";


                    SqlCommand command = new SqlCommand(query, SQL.connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dentistsData.Dentists = new DataTable();
                        dentistsData.Dentists.Load(reader);
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

                return dentistsData;
            }

        }
    }
