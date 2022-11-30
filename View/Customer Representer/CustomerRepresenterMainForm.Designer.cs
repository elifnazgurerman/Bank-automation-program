namespace BLM210_ProgramlamaLaboratuvari2_Proje3
{
    partial class CustomerRepresenterMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRepresenterMainForm));
            this.CustomerProcessButton = new System.Windows.Forms.Button();
            this.customerListDataGridView = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerProcessButton
            // 
            this.CustomerProcessButton.Location = new System.Drawing.Point(948, 582);
            this.CustomerProcessButton.Name = "CustomerProcessButton";
            this.CustomerProcessButton.Size = new System.Drawing.Size(146, 70);
            this.CustomerProcessButton.TabIndex = 0;
            this.CustomerProcessButton.Text = "Customer Processes";
            this.CustomerProcessButton.UseVisualStyleBackColor = true;
            this.CustomerProcessButton.Click += new System.EventHandler(this.CustomerProcessButton_Click);
            // 
            // customerListDataGridView
            // 
            this.customerListDataGridView.AllowUserToAddRows = false;
            this.customerListDataGridView.AllowUserToDeleteRows = false;
            this.customerListDataGridView.AllowUserToOrderColumns = true;
            this.customerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.username,
            this.password});
            this.customerListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.customerListDataGridView.Name = "customerListDataGridView";
            this.customerListDataGridView.ReadOnly = true;
            this.customerListDataGridView.RowHeadersWidth = 62;
            this.customerListDataGridView.RowTemplate.Height = 28;
            this.customerListDataGridView.Size = new System.Drawing.Size(1234, 564);
            this.customerListDataGridView.TabIndex = 1;
            this.customerListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListDataGridView_CellContentDoubleClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User ID";
            this.user_id.MinimumWidth = 8;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Width = 150;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 150;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 150;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 582);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(216, 70);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Location = new System.Drawing.Point(234, 582);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(216, 70);
            this.UpdateCustomerButton.TabIndex = 3;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Location = new System.Drawing.Point(456, 582);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(216, 70);
            this.DeleteCustomerButton.TabIndex = 4;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1100, 582);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(146, 70);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(687, 607);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(149, 20);
            this.SelectedCustomerLabel.TabIndex = 7;
            this.SelectedCustomerLabel.Text = "Selected Customer:";
            // 
            // SelectedCustomerTextBox
            // 
            this.SelectedCustomerTextBox.Location = new System.Drawing.Point(842, 604);
            this.SelectedCustomerTextBox.Name = "SelectedCustomerTextBox";
            this.SelectedCustomerTextBox.ReadOnly = true;
            this.SelectedCustomerTextBox.Size = new System.Drawing.Size(100, 26);
            this.SelectedCustomerTextBox.TabIndex = 8;
            // 
            // CustomerRepresenterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.SelectedCustomerTextBox);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.customerListDataGridView);
            this.Controls.Add(this.CustomerProcessButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRepresenterMainForm";
            this.Text = "ProLa Bank - Customer Representer";
            this.Load += new System.EventHandler(this.CustomerRepresenterMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerProcessButton;
        private System.Windows.Forms.DataGridView customerListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox SelectedCustomerTextBox;
    }
}