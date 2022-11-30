namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer_Representer
{
    partial class CustomerRepresenterUpdateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRepresenterUpdateUserForm));
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 315);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(280, 80);
            this.AddCustomerButton.TabIndex = 19;
            this.AddCustomerButton.Text = "Update Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // UpdateCustomerGroupBox
            // 
            this.UpdateCustomerGroupBox.Controls.Add(this.AddressLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.AddressTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.PasswordLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.UsernameLabel);
            this.UpdateCustomerGroupBox.Controls.Add(this.PasswordTextBox);
            this.UpdateCustomerGroupBox.Controls.Add(this.UsernameTextBox);
            this.UpdateCustomerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.UpdateCustomerGroupBox.Name = "UpdateCustomerGroupBox";
            this.UpdateCustomerGroupBox.Size = new System.Drawing.Size(280, 295);
            this.UpdateCustomerGroupBox.TabIndex = 18;
            this.UpdateCustomerGroupBox.TabStop = false;
            this.UpdateCustomerGroupBox.Text = "Update Customer";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 175);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 20);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(6, 198);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(268, 26);
            this.AddressTextBox.TabIndex = 6;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(6, 236);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(6, 259);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(268, 26);
            this.PhoneNumberTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 114);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 52);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 137);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 26);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(6, 75);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(268, 26);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // CustomerRepresenterUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 406);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.UpdateCustomerGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRepresenterUpdateUserForm";
            this.Text = "ProLa Bank - Customer Representer - Update User";
            this.Load += new System.EventHandler(this.CustomerRepresenterUpdateUserForm_Load);
            this.UpdateCustomerGroupBox.ResumeLayout(false);
            this.UpdateCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.GroupBox UpdateCustomerGroupBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
    }
}