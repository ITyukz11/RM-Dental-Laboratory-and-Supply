namespace RM_Dental_Laboratory_and_Supplies.UserControls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.balanceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dentistidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmdbDataSet = new RM_Dental_Laboratory_and_Supplies.rmdbDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDentistBtn = new System.Windows.Forms.Button();
            this.AddCaseBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.balancesTableAdapter = new RM_Dental_Laboratory_and_Supplies.rmdbDataSetTableAdapters.balancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.balanceidDataGridViewTextBoxColumn,
            this.totalbalanceDataGridViewTextBoxColumn,
            this.dentistidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.balancesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // balanceidDataGridViewTextBoxColumn
            // 
            this.balanceidDataGridViewTextBoxColumn.DataPropertyName = "balance_id";
            this.balanceidDataGridViewTextBoxColumn.HeaderText = "balance_id";
            this.balanceidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.balanceidDataGridViewTextBoxColumn.Name = "balanceidDataGridViewTextBoxColumn";
            this.balanceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalbalanceDataGridViewTextBoxColumn
            // 
            this.totalbalanceDataGridViewTextBoxColumn.DataPropertyName = "total_balance";
            this.totalbalanceDataGridViewTextBoxColumn.HeaderText = "total_balance";
            this.totalbalanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalbalanceDataGridViewTextBoxColumn.Name = "totalbalanceDataGridViewTextBoxColumn";
            this.totalbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dentistidDataGridViewTextBoxColumn
            // 
            this.dentistidDataGridViewTextBoxColumn.DataPropertyName = "dentist_id";
            this.dentistidDataGridViewTextBoxColumn.HeaderText = "dentist_id";
            this.dentistidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dentistidDataGridViewTextBoxColumn.Name = "dentistidDataGridViewTextBoxColumn";
            this.dentistidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balancesBindingSource
            // 
            this.balancesBindingSource.DataMember = "balances";
            this.balancesBindingSource.DataSource = this.rmdbDataSet;
            // 
            // rmdbDataSet
            // 
            this.rmdbDataSet.DataSetName = "rmdbDataSet";
            this.rmdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 335);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 335);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 29);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter:";
            // 
            // AddDentistBtn
            // 
            this.AddDentistBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddDentistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDentistBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddDentistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDentistBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDentistBtn.ForeColor = System.Drawing.Color.Black;
            this.AddDentistBtn.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.dentist;
            this.AddDentistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDentistBtn.Location = new System.Drawing.Point(177, 5);
            this.AddDentistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddDentistBtn.Name = "AddDentistBtn";
            this.AddDentistBtn.Size = new System.Drawing.Size(164, 77);
            this.AddDentistBtn.TabIndex = 5;
            this.AddDentistBtn.Text = "Add Dentist";
            this.AddDentistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDentistBtn.UseVisualStyleBackColor = false;
            this.AddDentistBtn.Click += new System.EventHandler(this.AddDentistBtn_Click);
            // 
            // AddCaseBtn
            // 
            this.AddCaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddCaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCaseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddCaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCaseBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCaseBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCaseBtn.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.add__1_;
            this.AddCaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCaseBtn.Location = new System.Drawing.Point(4, 5);
            this.AddCaseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCaseBtn.Name = "AddCaseBtn";
            this.AddCaseBtn.Size = new System.Drawing.Size(164, 77);
            this.AddCaseBtn.TabIndex = 4;
            this.AddCaseBtn.Text = "Add Case";
            this.AddCaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCaseBtn.UseVisualStyleBackColor = false;
            this.AddCaseBtn.Click += new System.EventHandler(this.AddCaseBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.Black;
            this.AddUserBtn.Image = global::RM_Dental_Laboratory_and_Supplies.Properties.Resources.add__2_;
            this.AddUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserBtn.Location = new System.Drawing.Point(1398, 5);
            this.AddUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(164, 77);
            this.AddUserBtn.TabIndex = 3;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // balancesTableAdapter
            // 
            this.balancesTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddDentistBtn);
            this.Controls.Add(this.AddCaseBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1566, 777);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button AddCaseBtn;
        private System.Windows.Forms.Button AddDentistBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dentistidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balancesBindingSource;
        private rmdbDataSet rmdbDataSet;
        private rmdbDataSetTableAdapters.balancesTableAdapter balancesTableAdapter;
    }
}
