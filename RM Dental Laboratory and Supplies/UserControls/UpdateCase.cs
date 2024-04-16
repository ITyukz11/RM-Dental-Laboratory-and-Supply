using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Forms.Dashboard;
using RM_Dental_Laboratory_and_Supplies.Global.UpdateCase;
using RM_Dental_Laboratory_and_Supplies.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM_Dental_Laboratory_and_Supplies.UserControls
{
    public partial class UpdateCase : UserControl
    {
        SQLManagement_UpdateCase sql = new SQLManagement_UpdateCase();
        Forms.Update_Case.UpdateCase updateCase = new Forms.Update_Case.UpdateCase();
        private CaseData caseData;
        private int currentPage = 1;
        private readonly int pageSize = 5; // Number of records per page


        private string case_id;
        private string caseTypeCode;

        public UpdateCase()
        {
            InitializeComponent();
            InitializeAsync();
            Utils.DoubleBuffer doubleBuffer = new Utils.DoubleBuffer();
            doubleBuffer.SetDoubleBuffer(groupBox1, true);
            doubleBuffer.SetDoubleBuffer(groupBox2, true);
            doubleBuffer.SetDoubleBuffer(groupBox3, true);
            doubleBuffer.SetDoubleBuffer(groupBox4, true);

            doubleBuffer.SetDoubleBuffer(dataGridView1, true);

            // Attach KeyDown event handler to the SearchTb TextBox
            SearchTb.KeyDown += SearchTb_KeyDown;

            UpdateBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        
            //set to false when first load
            PreviousPageBtn.Enabled = false;
        }

        private async Task InitializeAsync()
        {
                await PopulateDataGridViewAsync();
                Global.Globals.DataTableCasesLoad = true;
                PageLbl.Text = currentPage.ToString();
        }

        public async Task PopulateDataGridViewAsync()
        {
            try
            {


                Console.WriteLine("PopulateDataGridViewAsync: Start");

            
                    Console.WriteLine("PopulateDataGridViewAsync: caseData or Cases DataTable is null. Retrieving data...");
                    caseData = await Task.Run(() => sql.RetrieveCases());
              

                    DisplayPage(currentPage);
                
              

                TotalCasesLbl.Text = dataGridView1.RowCount.ToString();
                TotalPageLbl.Text = TotalPages().ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("PopulateDataGridViewAsync: Error - " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            finally
            {

                Console.WriteLine("PopulateDataGridViewAsync: Completed");
            }
        }



        public void DisplayPage(int pageNumber)
        {
            // Calculate start index and end index for the current page
            int startIndex = (pageNumber - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, caseData.Cases.Rows.Count);

            // Create a new DataTable for the current page
            DataTable pageDataTable = caseData.Cases.Clone();

            // Copy records for the current page to the new DataTable
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(caseData.Cases.Rows[i]);
            }

            // Set the DataSource of the DataGridView to the DataTable for the current page
            dataGridView1.DataSource = pageDataTable;
        }

        // Calculate the total number of pages
        private int TotalPages()
        {       
                int totalPages = (int)Math.Ceiling((double)caseData.Cases.Rows.Count / pageSize);
                return totalPages;
        }


        // Button click event handler for next page
        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages())
            {
                currentPage++;
                DisplayPage(currentPage);
                UpdatePaginationButtons();
                PageLbl.Text = currentPage.ToString();
            }
        }

        // Button click event handler for previous page
        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage(currentPage);
                UpdatePaginationButtons();
                PageLbl.Text = currentPage.ToString();
            }
        }

        // Update the pagination buttons based on the current page
        private void UpdatePaginationButtons()
        {
            PreviousPageBtn.Enabled = (currentPage > 1);
            NextPageBtn.Enabled = (currentPage < TotalPages());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string filterColumn = FilterCb.SelectedItem.ToString();
            string searchQuery = SearchTb.Text;
            DataTable dataTable = sql.RetrieveCases(filterColumn, searchQuery);

            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
                TotalCasesLbl.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                MessageBox.Show("Failed to retrieve cases data.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is within a valid row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Access the desired cell values using column names or indexes
                string caseId = selectedRow.Cells["Case ID"].Value.ToString();
                string patientName = selectedRow.Cells["Patient Name"].Value.ToString();
                DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["Due Date"].Value);
                TimeSpan dueTime = (TimeSpan)selectedRow.Cells["Due Time"].Value;
                DateTime dueDateTime = DateTime.Today.Add(dueTime); // Combine with today's date to create a DateTime object
                ProvidedTb.Text = selectedRow.Cells["provided"].Value.ToString();
                caseTypeCode = selectedRow.Cells["Case Type/Code"].Value.ToString();
                int dentistId = Convert.ToInt32(selectedRow.Cells["Dentist ID"].Value);


                // Display the data in labels
                CaseID.Text = caseId;
                CaseTypeCodeLbl.Text = caseTypeCode;
                PatientNameLbl.Text = patientName;

                DueDateLbl.Text = dueDate.ToString("MM/dd/yyyy");
          
                DueTimeLbl.Text = dueDateTime.ToString("hh:mm tt");
                DentistIdLbl.Text = dentistId.ToString();
                DentistNameLbl.Text= sql.GetDentistName(dentistId);

                TotalCasesLbl.Text = dataGridView1.RowCount.ToString();

                UpdateBtn.Enabled = true;
                DeleteBtn.Enabled = true;

                //store value case_id for update form
                case_id = caseId;

            }   
        }       
                
                
                
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateCase.ShowDialog();
        }
                
        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            AddCase addCaseForm = new AddCase(this); // Pass a reference to the current instance of UpdateCase
            addCaseForm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateCase.SetCaseId(case_id);
            updateCase.ShowDialog();
        }

        private void SearchTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the search button click event
                SearchButton_Click(sender, e);
            }

        }

        public async void DeleteBtn_Click(object sender, EventArgs e)
        {
           DialogResult response = MessageBox.Show($"Are you sure you want to delete {caseTypeCode} case?","Deleting Case",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(response == DialogResult.Yes)
            {
                try
                {

                    bool result = sql.DeleteCase(case_id);

                    if (result)
                    {
                        MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await PopulateDataGridViewAsync();

                        Global.Globals.DataTableCasesLoad = false;
                    }
                    else MessageBox.Show($"Error deleting {caseTypeCode} case", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error deleting {caseTypeCode} case, {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                
            }
            
        }
        private void ProvidedTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void UpdateCase_Load(object sender, EventArgs e)
        {
            await PopulateDataGridViewAsync();
        }
    }
}
