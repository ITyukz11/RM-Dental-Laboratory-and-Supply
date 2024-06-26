﻿using System;
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
        public SqlConnection connection = new SqlConnection(@"Server=ADMINISTRATOR; Database=rmdb; User Id=sa; Password=admin");
        public SqlCommand command = new SqlCommand();
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

        //Add dentists
        public bool InsertData(string fullname, string address, string contact_number, string email)
        {
            try
            {
                connection.Open();

                // Check if dbo.dentists table exists, if not, create it
                string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'dentists')
            BEGIN
                CREATE TABLE dbo.dentists (
                    dentist_id INT PRIMARY KEY IDENTITY,
                    full_name NVARCHAR(255),
                    address NVARCHAR(255),
                    contact_num NVARCHAR(20),
                    email_address NVARCHAR(255)
                );
                PRINT 'dbo.dentists table created successfully.';
            END";

                SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();

                // Insert data into dbo.dentists table
                string insertQuery = "INSERT INTO dbo.dentists (full_name, address, contact_num, email_address) VALUES (@fullname, @address, @contactnumber, @email)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                // Set the parameter values
                insertCommand.Parameters.AddWithValue("@fullname", fullname);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@contactnumber", contact_number);
                insertCommand.Parameters.AddWithValue("@email", email);

                int result = insertCommand.ExecuteNonQuery();

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

        //ADD CASE
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

        public bool InsertCase(string case_type_code, string patient_name, DateTime record_date, TimeSpan record_time, string status,
      string case_, string description, DateTime due_date, TimeSpan due_time, string remarks, string provided, byte[] image, int dentist_id, int user_id)
        {
            try
            {
                connection.Open();

                // Check if dbo.cases table exists, if not, create it
                string createTableQuery = @"
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cases')
    BEGIN
        CREATE TABLE dbo.cases (
            case_id INT PRIMARY KEY IDENTITY,
            case_type_code NVARCHAR(255),
            patient_name NVARCHAR(255),
            record_date DATE,
            record_time TIME,
            [case] NVARCHAR(MAX),
            description NVARCHAR(MAX),
            due_date DATE,
            due_time TIME,
            status NVARCHAR(255),
            remarks NVARCHAR(MAX),
            provided NVARCHAR(255),
            image VARBINARY(MAX),
            new_case_image VARBINARY(MAX),
            process_image VARBINARY(MAX),
            dentist_id INT,
            user_id INT,
            CONSTRAINT FK_dentist_id FOREIGN KEY (dentist_id) REFERENCES dbo.dentists(dentist_id),
            CONSTRAINT FK_user_id FOREIGN KEY (user_id) REFERENCES dbo.users(user_id)
        );
        PRINT 'dbo.cases table created successfully.';
    END";


                SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();

                // Insert case data
                string insertQuery = @"
            INSERT INTO dbo.cases (case_type_code, patient_name, record_date, record_time, status, [case], description, due_date, due_time, remarks, provided, image, dentist_id, user_id)
            VALUES (@case_type_code, @patient_name, @record_date, @record_time, @status, @case, @description, @due_date, @due_time, @remarks, @provided, @image, @dentist_id, @user_id)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@case_type_code", case_type_code);
                insertCommand.Parameters.AddWithValue("@patient_name", patient_name);
                insertCommand.Parameters.AddWithValue("@record_date", record_date);
                insertCommand.Parameters.AddWithValue("@record_time", record_time);
                insertCommand.Parameters.AddWithValue("@status", status);
                insertCommand.Parameters.AddWithValue("@case", case_);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.Parameters.AddWithValue("@due_date", due_date);
                insertCommand.Parameters.AddWithValue("@due_time", due_time);
                insertCommand.Parameters.AddWithValue("@remarks", remarks);
                insertCommand.Parameters.AddWithValue("@provided", provided);
                insertCommand.Parameters.AddWithValue("@image", image);
                insertCommand.Parameters.AddWithValue("@dentist_id", dentist_id);
                insertCommand.Parameters.AddWithValue("@user_id", user_id);

                int rowsAffected = insertCommand.ExecuteNonQuery();
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
                connection.Close();
            }
        }

    }
}
