using System.Drawing;

namespace RM_Dental_Laboratory_and_Supplies
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentUserLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.MaximizePB = new System.Windows.Forms.PictureBox();
            this.ClosePB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillinSoaBtn = new System.Windows.Forms.Button();
            this.OutCasesBtn = new System.Windows.Forms.Button();
            this.BillingSOAPanel = new System.Windows.Forms.Panel();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.ViewDatasBtn = new System.Windows.Forms.Button();
            this.DueCasesBtn = new System.Windows.Forms.Button();
            this.OutCasesPanel = new System.Windows.Forms.Panel();
            this.ViewDatasPanel = new System.Windows.Forms.Panel();
            this.DueCasesPanel = new System.Windows.Forms.Panel();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.MinimizePB);
            this.panel2.Controls.Add(this.MaximizePB);
            this.panel2.Controls.Add(this.ClosePB);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1566, 77);
            this.panel2.TabIndex = 4;
            // 
            // CurrentUserLbl
            // 
            this.CurrentUserLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CurrentUserLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserLbl.ForeColor = System.Drawing.Color.White;
            this.CurrentUserLbl.Location = new System.Drawing.Point(4, 0);
            this.CurrentUserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentUserLbl.Name = "CurrentUserLbl";
            this.CurrentUserLbl.Size = new System.Drawing.Size(61, 28);
            this.CurrentUserLbl.TabIndex = 4;
            this.CurrentUserLbl.Text = "User";
            this.CurrentUserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CurrentUserLbl.TextChanged += new System.EventHandler(this.CurrentUserLbl_TextChanged);
            this.CurrentUserLbl.Click += new System.EventHandler(this.CurrentUserLbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(1385, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MinimizePB
            // 
            this.MinimizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.minimize_icon;
            this.MinimizePB.Location = new System.Drawing.Point(1458, 18);
            this.MinimizePB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizePB.Name = "MinimizePB";
            this.MinimizePB.Size = new System.Drawing.Size(24, 25);
            this.MinimizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePB.TabIndex = 2;
            this.MinimizePB.TabStop = false;
            this.MinimizePB.Click += new System.EventHandler(this.MinimizePB_Click);
            // 
            // MaximizePB
            // 
            this.MaximizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizePB.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.maximize_icon;
            this.MaximizePB.Location = new System.Drawing.Point(1491, 18);
            this.MaximizePB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizePB.Name = "MaximizePB";
            this.MaximizePB.Size = new System.Drawing.Size(24, 25);
            this.MaximizePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizePB.TabIndex = 1;
            this.MaximizePB.TabStop = false;
            this.MaximizePB.Click += new System.EventHandler(this.MaximizePB_Click);
            // 
            // ClosePB
            // 
            this.ClosePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePB.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.close_icon;
            this.ClosePB.Location = new System.Drawing.Point(1524, 18);
            this.ClosePB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClosePB.Name = "ClosePB";
            this.ClosePB.Size = new System.Drawing.Size(24, 25);
            this.ClosePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePB.TabIndex = 0;
            this.ClosePB.TabStop = false;
            this.ClosePB.Click += new System.EventHandler(this.ClosePB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.clinic;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RM Dental Laboratory and Supplies System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.BillinSoaBtn);
            this.panel1.Controls.Add(this.OutCasesBtn);
            this.panel1.Controls.Add(this.BillingSOAPanel);
            this.panel1.Controls.Add(this.DashboardBtn);
            this.panel1.Controls.Add(this.ViewDatasBtn);
            this.panel1.Controls.Add(this.DueCasesBtn);
            this.panel1.Controls.Add(this.OutCasesPanel);
            this.panel1.Controls.Add(this.ViewDatasPanel);
            this.panel1.Controls.Add(this.DueCasesPanel);
            this.panel1.Controls.Add(this.DashboardPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 77);
            this.panel1.TabIndex = 5;
            // 
            // BillinSoaBtn
            // 
            this.BillinSoaBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillinSoaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BillinSoaBtn.FlatAppearance.BorderSize = 0;
            this.BillinSoaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BillinSoaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.BillinSoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillinSoaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillinSoaBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BillinSoaBtn.Location = new System.Drawing.Point(940, 0);
            this.BillinSoaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillinSoaBtn.Name = "BillinSoaBtn";
            this.BillinSoaBtn.Size = new System.Drawing.Size(225, 77);
            this.BillinSoaBtn.TabIndex = 6;
            this.BillinSoaBtn.Text = "Billing / SOA";
            this.BillinSoaBtn.UseVisualStyleBackColor = false;
            this.BillinSoaBtn.Click += new System.EventHandler(this.BillinSoaBtn_Click);
            // 
            // OutCasesBtn
            // 
            this.OutCasesBtn.BackColor = System.Drawing.Color.Transparent;
            this.OutCasesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutCasesBtn.FlatAppearance.BorderSize = 0;
            this.OutCasesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.OutCasesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.OutCasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutCasesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutCasesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OutCasesBtn.Location = new System.Drawing.Point(706, 0);
            this.OutCasesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutCasesBtn.Name = "OutCasesBtn";
            this.OutCasesBtn.Size = new System.Drawing.Size(225, 77);
            this.OutCasesBtn.TabIndex = 3;
            this.OutCasesBtn.Text = "Out Cases";
            this.OutCasesBtn.UseVisualStyleBackColor = false;
            this.OutCasesBtn.Click += new System.EventHandler(this.OutCasesBtn_Click);
            // 
            // BillingSOAPanel
            // 
            this.BillingSOAPanel.BackColor = System.Drawing.Color.Red;
            this.BillingSOAPanel.Location = new System.Drawing.Point(940, 69);
            this.BillingSOAPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillingSOAPanel.Name = "BillingSOAPanel";
            this.BillingSOAPanel.Size = new System.Drawing.Size(225, 8);
            this.BillingSOAPanel.TabIndex = 6;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DashboardBtn.Location = new System.Drawing.Point(4, 0);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(225, 77);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // ViewDatasBtn
            // 
            this.ViewDatasBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewDatasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDatasBtn.FlatAppearance.BorderSize = 0;
            this.ViewDatasBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.ViewDatasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.ViewDatasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDatasBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDatasBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewDatasBtn.Location = new System.Drawing.Point(472, 0);
            this.ViewDatasBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewDatasBtn.Name = "ViewDatasBtn";
            this.ViewDatasBtn.Size = new System.Drawing.Size(225, 77);
            this.ViewDatasBtn.TabIndex = 2;
            this.ViewDatasBtn.Text = "View Datas";
            this.ViewDatasBtn.UseVisualStyleBackColor = false;
            this.ViewDatasBtn.Click += new System.EventHandler(this.ViewDatasBtn_Click);
            // 
            // DueCasesBtn
            // 
            this.DueCasesBtn.BackColor = System.Drawing.Color.Transparent;
            this.DueCasesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DueCasesBtn.FlatAppearance.BorderSize = 0;
            this.DueCasesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.DueCasesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.DueCasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DueCasesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueCasesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DueCasesBtn.Location = new System.Drawing.Point(238, 0);
            this.DueCasesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DueCasesBtn.Name = "DueCasesBtn";
            this.DueCasesBtn.Size = new System.Drawing.Size(225, 77);
            this.DueCasesBtn.TabIndex = 1;
            this.DueCasesBtn.Text = "Due Cases";
            this.DueCasesBtn.UseVisualStyleBackColor = false;
            this.DueCasesBtn.Click += new System.EventHandler(this.DueCasesBtn_Click);
            // 
            // OutCasesPanel
            // 
            this.OutCasesPanel.BackColor = System.Drawing.Color.Red;
            this.OutCasesPanel.Location = new System.Drawing.Point(706, 69);
            this.OutCasesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutCasesPanel.Name = "OutCasesPanel";
            this.OutCasesPanel.Size = new System.Drawing.Size(225, 8);
            this.OutCasesPanel.TabIndex = 5;
            // 
            // ViewDatasPanel
            // 
            this.ViewDatasPanel.BackColor = System.Drawing.Color.Red;
            this.ViewDatasPanel.Location = new System.Drawing.Point(472, 69);
            this.ViewDatasPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewDatasPanel.Name = "ViewDatasPanel";
            this.ViewDatasPanel.Size = new System.Drawing.Size(225, 8);
            this.ViewDatasPanel.TabIndex = 5;
            // 
            // DueCasesPanel
            // 
            this.DueCasesPanel.BackColor = System.Drawing.Color.Red;
            this.DueCasesPanel.Location = new System.Drawing.Point(238, 69);
            this.DueCasesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DueCasesPanel.Name = "DueCasesPanel";
            this.DueCasesPanel.Size = new System.Drawing.Size(225, 8);
            this.DueCasesPanel.TabIndex = 5;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.Red;
            this.DashboardPanel.Location = new System.Drawing.Point(4, 69);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(225, 8);
            this.DashboardPanel.TabIndex = 4;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 154);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1566, 777);
            this.PanelContainer.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CurrentUserLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1307, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(71, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 931);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button ViewDatasBtn;
        private System.Windows.Forms.Button DueCasesBtn;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel OutCasesPanel;
        private System.Windows.Forms.Panel ViewDatasPanel;
        private System.Windows.Forms.Panel DueCasesPanel;
        private System.Windows.Forms.Button OutCasesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ClosePB;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox MaximizePB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CurrentUserLbl;
        private System.Windows.Forms.Button BillinSoaBtn;
        private System.Windows.Forms.Panel BillingSOAPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

