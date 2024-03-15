using RM_Dental_Laboratory_and_Supplies.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Forms.Dashboard
{
    public partial class AddCase : Form
    {
        Database.SQLManagement sql = new SQLManagement();

        public string current_user { get; set; }

        public void SetCurrentUser(string username)
        {
            current_user = username;
        }

        public AddCase()
        {
            InitializeComponent();

            //LOAD DENTISTS NAMES TO COMBOBOX
            sql.PopulateDentistComboBox(DentistNameCB, DentistID);
            UserTb.Text = this.current_user;
            TimeTb.Text = DateTime.Now.ToString();

            // Set KeyPreview to true to capture key events at the form level
            this.KeyPreview = true;

            // Hook up KeyDown event handler for the form
            this.KeyDown += AddCase_KeyDown;
        }

        private void AddCase_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Escape key is pressed
            if (e.KeyCode == Keys.Escape)
            {
                // Close the form
                this.Close();
            }
        }

        private void AddCase_Load(object sender, EventArgs e)
        {

        }
    }
}
