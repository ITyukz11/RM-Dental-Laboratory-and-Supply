﻿using System;
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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void AddDentistBtn_Click(object sender, EventArgs e)
        {
            Forms.Dashboard.AddDentist addDentist = new Forms.Dashboard.AddDentist();
            addDentist.ShowDialog();
        }
    }
}
