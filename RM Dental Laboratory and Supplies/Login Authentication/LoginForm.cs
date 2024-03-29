using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Forms.Dashboard;
using RM_Dental_Laboratory_and_Supplies.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM_Dental_Laboratory_and_Supplies.Login_Authentication
{
    public partial class LoginForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        public LoginForm()
        {
            InitializeComponent();
            // Hook up Paint event handlers for the textboxes

            PasswordTb.UseSystemPasswordChar = true;

            Utils.FormUtils.PerformClickOnEnterKey(this, SubmitBtn);
            // set form border radius round
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public string Current_user { get; private set; } // Encapsulated property

        public void SetCurrentUser(string username)
        {
            Current_user = username;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the progress bar
                UsernameTB.Enabled = false;
                PasswordTb.Enabled = false;
                checkBox1.Enabled = false;
                SubmitBtn.Enabled = false;
                ExitBtn.Enabled = false;

                SQLManagement_Login SQL = new SQLManagement_Login();

                if (UsernameTB.Text.Length == 0 || PasswordTb.Text.Length == 0)
                {
                    MessageBox.Show("Please fill out all the blanks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Call the LoginAuth method asynchronously
                    string result = await SQL.LoginAuth(UsernameTB.Text, PasswordTb.Text);

                    if (result == "success")
                    {
                        MainForm mainform = new MainForm();

                        // Set the Username property in the Globals class
                        Globals.Current_User = UsernameTB.Text;
                        MessageBox.Show("Login success.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mainform.Show();
                        this.Hide();
                    }
                    else if (result == "invalid")
                    {
                        MessageBox.Show("Login failed. Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while connecting to the server. Please check your connection settings and try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide the progress bar after login process completes
                UsernameTB.Enabled = true;
                PasswordTb.Enabled = true;
                checkBox1.Enabled = true;
                SubmitBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
        }







        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                PasswordTb.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = true;
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }


}
