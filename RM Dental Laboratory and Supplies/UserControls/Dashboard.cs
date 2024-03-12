using RM_Dental_Laboratory_and_Supplies.Forms.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.UserControls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void AddCaseBtn_Click(object sender, EventArgs e)
        {
            Forms.Dashboard.AddCase addCase = new Forms.Dashboard.AddCase();
            addCase.ShowDialog();
        }

        private void AddDentistBtn_Click(object sender, EventArgs e)
        {
            Forms.Dashboard.AddDentist addDentist = new Forms.Dashboard.AddDentist();
            addDentist.ShowDialog();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            Forms.Dashboard.AddUser addUser = new Forms.Dashboard.AddUser();
            addUser.ShowDialog();
        }
    }
}
