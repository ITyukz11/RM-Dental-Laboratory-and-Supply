using RM_Dental_Laboratory_and_Supplies.Global;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Database
{
    public class SQLManagement_Login
    {
        SQLManagement SQL = new SQLManagement();

        public async Task<string> LoginAuth(string username, string password)
        {
            try
            {
                using (SqlConnection connection = SQL.connection)
                {
                    await connection.OpenAsync();

                    string query = "SELECT users_id FROM dbo.users WHERE username=@username AND password=@password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = await command.ExecuteScalarAsync();

                        if (result != null)
                        {
                            Globals.Current_User_Id = result.ToString();
                            return "success";
                        }
                        else
                        {
                            return "invalid";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "error";
            }
        }




    }
}
