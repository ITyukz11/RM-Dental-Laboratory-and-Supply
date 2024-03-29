using RM_Dental_Laboratory_and_Supplies.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM_Dental_Laboratory_and_Supplies.UserControls
{
    public  partial class DUE_CASES : UserControl
    {
        public DUE_CASES()
        {
            InitializeComponent();

            
        }
        //private async void DUE_CASES_Load(object sender, EventArgs e)
        //{
        //    await PopulateDataGridViewAsync();
        //}
        //public async Task PopulateDataGridViewAsync()
        //{
        //    try
        //    {
        //        // Show the ProgressBar
        //        progressBar1.Style = ProgressBarStyle.Marquee;
        //        progressBar1.Visible = true;

        //        SQLManagement_UpdateCase sql = new SQLManagement_UpdateCase();
        //        DataTable dataTable = await Task.Run(() => sql.RetrieveCases());

        //        if (dataTable != null)
        //        {
        //            dataGridView1.DataSource = dataTable;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to retrieve cases data.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        TotalCasesLbl.Text = dataGridView1.RowCount.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        // Hide the ProgressBar
        //        progressBar1.Visible = false;
        //    }
        //}

    
    }
}
