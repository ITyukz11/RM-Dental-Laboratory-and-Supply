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
    }
}
