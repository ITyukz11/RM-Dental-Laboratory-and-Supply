using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Global;
using RM_Dental_Laboratory_and_Supplies.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Forms.Dashboard
{
    public partial class AddCase : Form
    {
        Database.SQLManagement sql = new SQLManagement();
        private byte[] imageData;

        private UserControls.UpdateCase _updateCaseForm;
        public AddCase(UserControls.UpdateCase updateCaseForm)
        {
            InitializeComponent();

            this._updateCaseForm = updateCaseForm;

            OthersTxt.Enabled = false;

            //LOAD DENTISTS NAMES TO COMBOBOX
            sql.PopulateDentistComboBox(DentistNameCB, DentistID);

            //setup current user from globals
            UserTb.Text = Globals.Current_User;


            // Set KeyPreview to true to capture key events at the form level
            this.KeyPreview = true;



            // Call the utility method to close the form on Escape key press
            FormUtils.CloseOnEscapeKeyDown(this);

            // Call the utility method to perform click on SubmitBtn on Enter key press
            FormUtils.PerformClickOnEnterKey(this, SubmitBtn);
        }


        private void AddCase_Load(object sender, EventArgs e)
        {

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into the PictureBox
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.Image = selectedImage;

                        // Convert the image to a byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageData = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void OthersCB_CheckedChanged(object sender, EventArgs e)
        {
            OthersTxt.Enabled = OthersCB.Checked;
        }

        private void ShadeGuideCb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOthersText(ShadeGuideCb,"Shade Guide, ", "Shade Guide, ");
        }

        private void BiteWaxCb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOthersText(BiteWaxCb,"Bite Wax, ", "Bite Wax, ");
        }

        private void ArticulatorCb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOthersText(ArticulatorCb, "Articulator, ", "Articulator, ");
        }

        private void PorcelainCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOthersText(PorcelainCb, "Porcelain, ", "Porcelain, ");
        }

        //METHOD FOR UPDATING THE OTHERS TEXTBOX
        private void UpdateOthersText(CheckBox checkBox, string textToAdd, string textToRemove)
        {
            if (checkBox.Checked && !OthersTxt.Text.Contains(textToAdd))
            {
                // Append the corresponding text to OthersTxt TextBox if checkbox is checked
                OthersTxt.Text += textToAdd;
            }
            else if (!checkBox.Checked && OthersTxt.Text.Contains(textToRemove))
            {
                // Remove the corresponding text from OthersTxt TextBox if checkbox is unchecked
                OthersTxt.Text = OthersTxt.Text.Replace(textToRemove, "");
            }
        }



        private void CaseNumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and the delete key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void DateManualCb_CheckedChanged(object sender, EventArgs e)
        {
            CurrentDate.Enabled = DateManualCb.Checked;
            CurrentTime.Enabled = DateManualCb.Checked;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder("Please fill out all the following fields before submitting:\n");
            if (string.IsNullOrEmpty(DentistID.Text))
            {
                errorMessage.AppendLine("- Customer/Dentist");
            }

            if (string.IsNullOrEmpty(CaseTypeCB.Text))
            {
                errorMessage.AppendLine("- Case Type");
            }

            if (string.IsNullOrEmpty(CaseCodeTb.Text))
            {
                errorMessage.AppendLine("- Case Code");
            }

            if (string.IsNullOrEmpty(PatientNameTB.Text))
            {
                errorMessage.AppendLine("- Patient Name");
            }

            if (string.IsNullOrEmpty(StatusTB.Text))
            {
                errorMessage.AppendLine("- Status");
            }

            if (string.IsNullOrEmpty(CaseTB.Text))
            {
                errorMessage.AppendLine("- Case");
            }

            if (string.IsNullOrEmpty(DescriptionTB.Text))
            {
                errorMessage.AppendLine("- Description");
            }

            if (string.IsNullOrEmpty(RemarksTb.Text))
            {
                errorMessage.AppendLine("- Remarks");
            }

            if (string.IsNullOrEmpty(OthersTxt.Text))
            {
                errorMessage.AppendLine("- Provided/Others");
            }

            if (pictureBox1.Image == null)
            {
                errorMessage.AppendLine("- Photo");
            }

            // Check if any required fields are empty
            if (errorMessage.Length > "Please fill out all the following fields before submitting:\n".Length)
            {
                MessageBox.Show(errorMessage.ToString(), "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //SUBMIT NEW CASE
                SQLManagement sql = new SQLManagement();
                Global.UpdateCase.CaseData caseData = new Global.UpdateCase.CaseData();

                try
                {
                    Global.Globals.DataTableCasesLoad = false;
                    bool result = sql.InsertCase(
                        CaseTypeCB.Text + CaseCodeTb.Text,
                        PatientNameTB.Text,
                        CurrentDate.Value.Date,
                        CurrentTime.Value.TimeOfDay,
                        StatusTB.Text,
                        CaseTB.Text,
                        DescriptionTB.Text,
                        DueDatePicker.Value.Date,
                        DueTimePicker.Value.TimeOfDay,
                        RemarksTb.Text,
                        OthersTxt.Text,
                        ConvertPictureBoxToByteArray(pictureBox1), // Convert PictureBox image to byte array
                        Convert.ToInt32(DentistID.Text),
                        Convert.ToInt32(Globals.Current_User_Id)
                    );

                    // Update CaseData object with new case data
                    caseData.Cases.Rows.Add(
                        CaseTypeCB.Text + CaseCodeTb.Text,
                        PatientNameTB.Text,
                        CaseTypeCB.Text,
                        CurrentTime.Value.TimeOfDay.ToString(),
                        CurrentDate.Value.Date.ToString(),
                        StatusTB.Text,
                        CaseTB.Text,
                        DescriptionTB.Text,
                        DueTimePicker.Value.TimeOfDay.ToString(),
                        DueDatePicker.Value.Date.ToString(),
                        RemarksTb.Text,
                        OthersTxt.Text,
                        Globals.Current_User_Id
                    );
                    caseData.PatientName = PatientNameTB.Text;

                    if (result)
                    {
                        if (_updateCaseForm != null)
                        {
                            Global.Globals.DataTableCasesLoad = false;

                            caseData.PrintCasesData();

                            await _updateCaseForm.PopulateDataGridViewAsync();

                            this.Close();
                          


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // Method to convert PictureBox image to byte array
        private byte[] ConvertPictureBoxToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return null; // Return null if PictureBox image is empty
            }

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                return ms.ToArray(); // Convert image to byte array and return
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
