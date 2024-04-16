using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Global;
using RM_Dental_Laboratory_and_Supplies.Global.UpdateCase;
using RM_Dental_Laboratory_and_Supplies.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM_Dental_Laboratory_and_Supplies.Forms.Update_Case
{
    public partial class UpdateCase : Form
    {
        public string CaseID {get;set;}
        SQLManagement_UpdateCase SQL = new SQLManagement_UpdateCase();

        private UserControls.UpdateCase _updateCaseForm;
        private void UpdateCase_Load(object sender, EventArgs e)
        {
            LoadCaseData(CaseID);
        }


        public void SetCaseId(string case_id)
        {
            CaseID = case_id;
        }

        public UpdateCase()
        {
            InitializeComponent();
            CurrentDate.Enabled = false;
            CurrentTime.Enabled = false;

            DateCreatedDP.Enabled = false;
            TimeCreatedDP.Enabled = false;

            // Call the utility method to close the form on Escape key press
            FormUtils.CloseOnEscapeKeyDown(this);

            // Call the utility method to perform click on SubmitBtn on Enter key press
            FormUtils.PerformClickOnEnterKey(this, SubmitBtn);

           
        }


        private void DateManualCb_CheckedChanged(object sender, EventArgs e)
        {
            CurrentDate.Enabled=DateManualCb.Checked;
            CurrentTime.Enabled = DateManualCb.Checked;
        }

        public void LoadCaseData(string caseId)
        {
            UserTb.Text = Globals.Current_User;
            try
            {
                // Call your SQLManagement_UpdateCase method to retrieve all data for the given case_id
                CaseData caseData = SQL.RetrieveCaseById(caseId);

                // Check if the retrieved data is not null
                if (caseData != null)
                {
                    // Set the properties of your form using the retrieved data
                    PatientNameTB.Text = caseData.PatientName;
                    CaseCodeTb.Text = caseData.CaseTypeCode;
                    TimeCreatedDP.Text = caseData.TimeCreated;
                    DateCreatedDP.Text = caseData.DateCreated;
                    StatusTB.Text = caseData.Status;
                    CaseTB.Text = caseData.Case;
                    DescriptionTB.Text = caseData.Description;
                    DueTimePicker.Text = caseData.DueTime;
                    DueDatePicker.Text = caseData.DueDate;
                    RemarksTb.Text = caseData.Remarks;
                    OthersTxt.Text = caseData.Provided;
                    EncodedByTB.Text = caseData.Username;
                    // Set other properties or perform additional operations as needed
                }
                else
                {
                    // Handle case where data is not found
                    MessageBox.Show("Case data not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading case data: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            await _updateCaseForm.PopulateDataGridViewAsync();
        }
    }
}
