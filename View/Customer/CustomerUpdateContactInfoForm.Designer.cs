namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    partial class CustomerUpdateContactInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdateContactInfoForm));
            this.updateContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.updateContactInfoButton = new System.Windows.Forms.Button();
            this.updateContactInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateContactInfoGroupBox
            // 
            this.updateContactInfoGroupBox.Controls.Add(this.phoneLabel);
            this.updateContactInfoGroupBox.Controls.Add(this.addressLabel);
            this.updateContactInfoGroupBox.Controls.Add(this.phoneTextBox);
            this.updateContactInfoGroupBox.Controls.Add(this.addressTextBox);
            this.updateContactInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.updateContactInfoGroupBox.Name = "updateContactInfoGroupBox";
            this.updateContactInfoGroupBox.Size = new System.Drawing.Size(280, 260);
            this.updateContactInfoGroupBox.TabIndex = 0;
            this.updateContactInfoGroupBox.TabStop = false;
            this.updateContactInfoGroupBox.Text = "Update Contact Info";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(6, 147);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 52);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(6, 170);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(268, 26);
            this.phoneTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(6, 75);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(268, 26);
            this.addressTextBox.TabIndex = 0;
            // 
            // updateContactInfoButton
            // 
            this.updateContactInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContactInfoButton.Location = new System.Drawing.Point(12, 278);
            this.updateContactInfoButton.Name = "updateContactInfoButton";
            this.updateContactInfoButton.Size = new System.Drawing.Size(280, 80);
            this.updateContactInfoButton.TabIndex = 13;
            this.updateContactInfoButton.Text = "Update Contact Info";
            this.updateContactInfoButton.UseVisualStyleBackColor = true;
            this.updateContactInfoButton.Click += new System.EventHandler(this.updateContactInfoButton_Click);
            // 
            // CustomerUpdateContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 370);
            this.Controls.Add(this.updateContactInfoButton);
            this.Controls.Add(this.updateContactInfoGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerUpdateContactInfoForm";
            this.Text = "ProLa Bank - Customer - Update Contact Info";
            this.updateContactInfoGroupBox.ResumeLayout(false);
            this.updateContactInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox updateContactInfoGroupBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button updateContactInfoButton;
    }
}