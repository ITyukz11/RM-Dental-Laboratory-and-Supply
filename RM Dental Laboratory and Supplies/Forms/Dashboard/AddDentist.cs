﻿using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Forms.Dashboard
{
    public partial class AddDentist : Form
    {
        public AddDentist()
        {
            InitializeComponent();
            // Set KeyPreview to true to capture key events at the form level
            this.KeyPreview = true;

            // Call the utility method to close the form on Escape key press
            FormUtils.CloseOnEscapeKeyDown(this);

            // Call the utility method to perform click on SubmitBtn on Enter key press
            FormUtils.PerformClickOnEnterKey(this, SubmitBtn);
        }

      

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (new[] { FullnameTb.Text, AddressTb.Text, ContactNumTb.Text, EmailTb.Text }.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Please fill out all the blanks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                    SQLManagement sql = new SQLManagement();
                try
                {
                    bool result = sql.InsertData(FullnameTb.Text, AddressTb.Text, ContactNumTb.Text, EmailTb.Text);
                    if (result) this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   
                
            }
        }
    }
}
