using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Global.UpdateCase;
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
    public partial class Customer : UserControl
    {
        private DentistsData DentistsData;
        SQLManagement_Dentists sql = new SQLManagement_Dentists();
        private string DentistId;
        private int currentPage = 1;
        private readonly int pageSize = 5; // Number of records per page
        public Customer()
        {
            InitializeComponent();
            _ = InitializeAsync();

            Utils.DoubleBuffer doubleBuffer = new Utils.DoubleBuffer();
            doubleBuffer.SetDoubleBuffer(groupBox1, true);
            doubleBuffer.SetDoubleBuffer(groupBox2, true);
            doubleBuffer.SetDoubleBuffer(groupBox3, true);
            doubleBuffer.SetDoubleBuffer(groupBox4, true);

            doubleBuffer.SetDoubleBuffer(dataGridView1, true);

            UpdateBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }

        private async Task InitializeAsync()
        {
         
                await PopulateDataGridViewAsync();
                Global.Globals.DataTableDentistsLoad = true;
                PageLbl.Text = currentPage.ToString();
          

        }


        public void DisplayPage(int pageNumber)
        {
            // Calculate start index and end index for the current page
            int startIndex = (pageNumber - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, DentistsData.Dentists.Rows.Count);

            // Create a new DataTable for the current page
            DataTable pageDataTable = DentistsData.Dentists.Clone();

            // Copy records for the current page to the new DataTable
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(DentistsData.Dentists.Rows[i]);
            }

            // Set the DataSource of the DataGridView to the DataTable for the current page
            dataGridView1.DataSource = pageDataTable;
        }

        // Calculate the total number of pages
        private int TotalPages()
        {
            int totalPages = (int)Math.Ceiling((double)DentistsData.Dentists.Rows.Count / pageSize);
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

        private void AddDentistBtn_Click(object sender, EventArgs e)
        {
            Forms.Dashboard.AddDentist addDentist = new Forms.Dashboard.AddDentist();
            addDentist.ShowDialog();
        }

        public async Task PopulateDataGridViewAsync()
        {
            try
            {


                Console.WriteLine("PopulateDataGridViewAsync: Start");


                Console.WriteLine("PopulateDataGridViewAsync: DentistsData or Cases DataTable is null. Retrieving data...");
                DentistsData = await Task.Run(() => sql.RetrieveDentists());


               DisplayPage(currentPage);



                TotalCasesLbl.Text = dataGridView1.RowCount.ToString();
                //TotalPageLbl.Text = TotalPages().ToString();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is within a valid row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Access the desired cell values using column names or indexes
                string dentistId = selectedRow.Cells["Dentist ID"].Value.ToString();
                DentistIdLbl.Text = dentistId;
                DentistNameLbl.Text = selectedRow.Cells["Full Name"].Value.ToString();
                AddressLbl.Text = selectedRow.Cells["Address"].Value.ToString();
                EmailLbl.Text = selectedRow.Cells["Email Address"].Value.ToString();
                ContactNumLbl.Text = selectedRow.Cells["Contact Number"].Value.ToString();


                TotalCasesLbl.Text = dataGridView1.RowCount.ToString();

                UpdateBtn.Enabled = true;
                DeleteBtn.Enabled = true;

                //store value DentistId for update form
                DentistId = dentistId;

            }
        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            await PopulateDataGridViewAsync();
        }
    }
}
