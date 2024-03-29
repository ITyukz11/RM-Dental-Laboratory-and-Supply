using RM_Dental_Laboratory_and_Supplies.Database;
using RM_Dental_Laboratory_and_Supplies.Global;
using RM_Dental_Laboratory_and_Supplies.Global.UpdateCase;
using RM_Dental_Laboratory_and_Supplies.Login_Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies
{
    public partial class MainForm : Form
    {
        private Dictionary<Button, Panel> buttonPanelMap = new Dictionary<Button, Panel>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );

        public MainForm()
        {
            InitializeComponent();

            buttonPanelMap.Add(DashboardBtn, DashboardPanel);
            buttonPanelMap.Add(DueCasesBtn, DueCasesPanel);
            buttonPanelMap.Add(ViewDatasBtn, ViewDatasPanel);
            buttonPanelMap.Add(CustomerBtn, CustomerPanel);
            buttonPanelMap.Add(OutCasesBtn, OutCasesPanel);
            buttonPanelMap.Add(BillinSoaBtn, BillingSOAPanel);
            buttonPanelMap.Add(SettingsBtn, SettingsPanel);

            //DASHBOARD AS DEFAULT
            UserControls.Dashboard dashboard = new UserControls.Dashboard();
            addUserControl(dashboard);
            HandlePanelVisibility(buttonPanelMap, DashboardBtn);

            // set current user
            CurrentUserLbl.TextChanged += CurrentUserLbl_TextChanged;// Update UI with current user

            // set form border radius round
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }


        private UserControl currentControl = null;
        private CaseData caseData;

        SQLManagement_UpdateCase sql = new SQLManagement_UpdateCase();
        public void LoadCases()
        {
            // Retrieve cases data from database
            caseData = sql.RetrieveCases();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BackColor = Color.White;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();

            // Update the current control
            currentControl = userControl;
        }

        private void HandlePanelVisibility(Dictionary<Button, Panel> panelMap, Button clickedButton)
        {
            foreach (var entry in panelMap)
            {
                if (entry.Key == clickedButton)
                {
                    entry.Value.BringToFront();
                }
                else
                {
                    entry.Value.SendToBack();
                }
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.Dashboard))
            {
                UserControls.Dashboard dashboard = new UserControls.Dashboard();
                addUserControl(dashboard);
                HandlePanelVisibility(buttonPanelMap, DashboardBtn);
            }
        }

        private void DueCasesBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.DUE_CASES))
            {
                UserControls.DUE_CASES duecases = new UserControls.DUE_CASES();
                addUserControl(duecases);
                HandlePanelVisibility(buttonPanelMap, DueCasesBtn);
            }
        }

        private void ViewDatasBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.UpdateCase))
            {
                UserControls.UpdateCase viewcases = new UserControls.UpdateCase();
                addUserControl(viewcases);
                HandlePanelVisibility(buttonPanelMap, ViewDatasBtn);
            }
        }

        private void OutCasesBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.OutCases))
            {
                UserControls.OutCases outcases = new UserControls.OutCases();
                addUserControl(outcases);
                HandlePanelVisibility(buttonPanelMap, OutCasesBtn);
            }
        }

        private void BillinSoaBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.BillingSOA))
            {
                UserControls.BillingSOA billingSoa = new UserControls.BillingSOA();
                addUserControl(billingSoa);
                HandlePanelVisibility(buttonPanelMap, BillinSoaBtn);
            }
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.Customer))
            {
                UserControls.Customer customer = new UserControls.Customer();
                addUserControl(customer);
                HandlePanelVisibility(buttonPanelMap, CustomerBtn);
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (currentControl == null || !(currentControl is UserControls.Settings))
            {
                UserControls.Settings settings = new UserControls.Settings();
                addUserControl(settings);
                HandlePanelVisibility(buttonPanelMap, SettingsBtn);
            }
        }


        private void ClosePB_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("Are you sure you want to exit?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }

        }

        private void MinimizePB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizePB_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // If already maximized, restore to normal size
                this.WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            else
            {
                // Maximize the form

                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;


                this.Region = null;
            }
        }

        private void CurrentUserLbl_Click(object sender, EventArgs e)
        {

        }

        private void CurrentUserLbl_TextChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            // Calculate the preferred width based on the text content and font
            int preferredWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;

            // Add some padding to the calculated width
            preferredWidth += 10; // Adjust as needed

            // Set the label width
            label.Width = preferredWidth;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentUserLbl.Text = Globals.Current_User;

        }

  
    }
}
