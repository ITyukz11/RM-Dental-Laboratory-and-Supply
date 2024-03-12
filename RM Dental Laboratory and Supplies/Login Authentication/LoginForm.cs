using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Login_Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Hook up Paint event handlers for the textboxes

            PasswordTb.UseSystemPasswordChar = true;
            this.KeyPress += LoginForm_KeyPress;

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();


            mainform.Show();
            this.Hide();

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

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger the Submit button click event
                SubmitBtn.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
