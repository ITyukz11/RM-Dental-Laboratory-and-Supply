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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDentistBtn = new System.Windows.Forms.Button();
            this.AddCaseBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
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
            this.AddDentistBtn.Location = new System.Drawing.Point(118, 3);
            this.AddDentistBtn.Name = "AddDentistBtn";
            this.AddDentistBtn.Size = new System.Drawing.Size(109, 50);
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
            this.AddCaseBtn.Location = new System.Drawing.Point(3, 3);
            this.AddCaseBtn.Name = "AddCaseBtn";
            this.AddCaseBtn.Size = new System.Drawing.Size(109, 50);
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
            this.AddUserBtn.Location = new System.Drawing.Point(932, 3);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(109, 50);
            this.AddUserBtn.TabIndex = 3;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddDentistBtn);
            this.Controls.Add(this.AddCaseBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1044, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
