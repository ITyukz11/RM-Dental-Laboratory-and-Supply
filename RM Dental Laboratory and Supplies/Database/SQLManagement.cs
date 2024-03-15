using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RM_Dental_Laboratory_and_Supplies.Database
{
    public class SQLManagement
    {
        // TO BE FOLLOWED REMOVE THE NECESSARY CONNECTION STRINGS AND HIDE IT 
        SqlConnection connection = new SqlConnection(@"Server=ADMINISTRATOR; Database=rmdb; User Id=sa; Password=admin");
        SqlCommand command = new SqlCommand();

        public void TryConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("connected!");
            }catch(Exception ex)
            {
                MessageBox.Show("failed!");
            }
            finally{ connection.Close(); }
               
            
        }
        public bool InsertData(string fullname, string username, string password)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO dbo.users (full_name, username, password) VALUES (@fullname, @username, @password);";
                command = new SqlCommand(query, connection);

                // Set the parameter values
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Inserted Successfully!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool InsertData(string fullname, string address, string contact_number, string email)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO dbo.dentists (full_name, address, contact_num,email_address) VALUES (@fullname, @address, @contactnumber,@email);";
                command = new SqlCommand(query, connection);

                // Set the parameter values
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contactnumber", contact_number);
                command.Parameters.AddWithValue("@email", email);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Inserted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool LoginAuth(string username, string password)
        {
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.users WHERE username=@username AND password=@password";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar(); // ExecuteScalar() returns the first column of the first row

                if (count > 0)
                {
                    MessageBox.Show("Logged In Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect credentials please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        public void PopulateDentistComboBox(ComboBox dentist_name, TextBox dentist_id)
        {
            // Dictionary to store dentist names and their corresponding IDs
            Dictionary<string, int> dentistDictionary = new Dictionary<string, int>();

            try
            {
                connection.Open();
                string query = "SELECT dentist_id, full_name FROM dbo.dentists";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ComboBox
                    dentist_name.Items.Clear();
                    dentistDictionary.Clear();

                    // Add items to the ComboBox and Dictionary from the query results
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("dentist_id"));
                        string fullName = reader["full_name"].ToString();

                        // Add the full name to the ComboBox
                        dentist_name.Items.Add(fullName);
                        // Add the dentist_id to the dictionary with the full name as key
                        dentistDictionary.Add(fullName, id);
                    }

                    // Close the data reader
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // Handle SelectedIndexChanged event of dentist_name ComboBox
            dentist_name.SelectedIndexChanged += (sender, e) =>
            {
                // Get the selected dentist name
                string selectedDentistName = dentist_name.SelectedItem as string;
                // Check if the selected name exists in the dictionary
                if (dentistDictionary.ContainsKey(selectedDentistName))
                {
                    // Set the corresponding dentist_id in the TextBox
                    dentist_id.Text = dentistDictionary[selectedDentistName].ToString();
                }
            };
        }


    }
}
