using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Forms.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.KeyDown += LoginForm_KeyPress;
            this.KeyDown += PasswordTb_KeyDown;
            //this.KeyDown += UsernameTb_KeyDown;

            // set form border radius round
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public string Current_user { get; private set; } // Encapsulated property

        public void SetCurrentUser(string username)
        {
            Current_user = username;
        }


        private void LoginForm_KeyPress(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the Submit button click event
                SubmitBtn.PerformClick();
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLManagement sql = new SQLManagement();
                if(UsernameTB.Text.Length ==0 || PasswordTb.Text.Length==0 ) 
                { 
                    MessageBox.Show("Please fill out all the blanks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool result = sql.LoginAuth(UsernameTB.Text, PasswordTb.Text);

                    if (result)
                    {
                        MainForm mainform = new MainForm();

                        mainform.SetCurrentUser(UsernameTB.Text); // Set Current_user in MainForm

                        mainform.Show();
                        this.Hide();
                    }
                 
                }        
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Define the gradient colors
            Color color1 = Color.FromArgb(2, 56, 110); // Blue
            Color color2 = Color.FromArgb(19, 15, 64); // Sky Blue

            // Create a linear gradient brush
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            e.Graphics.FillRectangle(brush, rect);

            // Call the base OnPaint method to ensure the form is painted correctly
            base.OnPaint(e);
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
            this.Close();
        }

        private void PasswordTb_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the Submit button click event
                SubmitBtn.PerformClick();
            }
        }

        private void UsernameTB_KeyDown(object sender, KeyEventArgs e)
        {
          
                // Check if the Enter key is pressed
                if (e.KeyCode == Keys.Enter)
                {
                    // Trigger the Submit button click event
                    SubmitBtn.PerformClick();
                }
            
        }
    }


}
