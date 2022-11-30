namespace BLM210_ProgramlamaLaboratuvari2_Proje3
{
    partial class CustomerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            this.welcomeTitle = new System.Windows.Forms.Label();
            this.createDeleteWalletButton = new System.Windows.Forms.Button();
            this.updateContactInfoButton = new System.Windows.Forms.Button();
            this.logutButton = new System.Windows.Forms.Button();
            this.requestLoanButton = new System.Windows.Forms.Button();
            this.depositMoneyButton = new System.Windows.Forms.Button();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            this.ShowFinancialStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeTitle
            // 
            this.welcomeTitle.AutoSize = true;
            this.welcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTitle.Location = new System.Drawing.Point(12, 9);
            this.welcomeTitle.Name = "welcomeTitle";
            this.welcomeTitle.Size = new System.Drawing.Size(157, 37);
            this.welcomeTitle.TabIndex = 0;
            this.welcomeTitle.Text = "Welcome";
            // 
            // createDeleteWalletButton
            // 
            this.createDeleteWalletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDeleteWalletButton.Location = new System.Drawing.Point(12, 292);
            this.createDeleteWalletButton.Name = "createDeleteWalletButton";
            this.createDeleteWalletButton.Size = new System.Drawing.Size(280, 80);
            this.createDeleteWalletButton.TabIndex = 1;
            this.createDeleteWalletButton.Text = "Create/Delete Wallet";
            this.createDeleteWalletButton.UseVisualStyleBackColor = true;
            this.createDeleteWalletButton.Click += new System.EventHandler(this.CreateDeleteWalletButton_Click);
            // 
            // updateContactInfoButton
            // 
            this.updateContactInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContactInfoButton.Location = new System.Drawing.Point(966, 12);
            this.updateContactInfoButton.Name = "updateContactInfoButton";
            this.updateContactInfoButton.Size = new System.Drawing.Size(280, 80);
            this.updateContactInfoButton.TabIndex = 3;
            this.updateContactInfoButton.Text = "Update Contact Info";
            this.updateContactInfoButton.UseVisualStyleBackColor = true;
            this.updateContactInfoButton.Click += new System.EventHandler(this.UpdateContactInfoButton_Click);
            // 
            // logutButton
            // 
            this.logutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logutButton.Location = new System.Drawing.Point(1106, 592);
            this.logutButton.Name = "logutButton";
            this.logutButton.Size = new System.Drawing.Size(140, 60);
            this.logutButton.TabIndex = 4;
            this.logutButton.Text = "Logout";
            this.logutButton.UseVisualStyleBackColor = true;
            this.logutButton.Click += new System.EventHandler(this.logutButton_Click);
            // 
            // requestLoanButton
            // 
            this.requestLoanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLoanButton.Location = new System.Drawing.Point(966, 292);
            this.requestLoanButton.Name = "requestLoanButton";
            this.requestLoanButton.Size = new System.Drawing.Size(280, 80);
            this.requestLoanButton.TabIndex = 7;
            this.requestLoanButton.Text = "Request/Pay Loan";
            this.requestLoanButton.UseVisualStyleBackColor = true;
            this.requestLoanButton.Click += new System.EventHandler(this.requestLoanButton_Click);
            // 
            // depositMoneyButton
            // 
            this.depositMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositMoneyButton.Location = new System.Drawing.Point(494, 292);
            this.depositMoneyButton.Name = "depositMoneyButton";
            this.depositMoneyButton.Size = new System.Drawing.Size(280, 80);
            this.depositMoneyButton.TabIndex = 5;
            this.depositMoneyButton.Text = "Deposit/Withdraw Money";
            this.depositMoneyButton.UseVisualStyleBackColor = true;
            this.depositMoneyButton.Click += new System.EventHandler(this.DepositWithdrawMoneyButton_Click);
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferMoneyButton.Location = new System.Drawing.Point(494, 378);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(280, 80);
            this.transferMoneyButton.TabIndex = 9;
            this.transferMoneyButton.Text = "Transfer Money";
            this.transferMoneyButton.UseVisualStyleBackColor = true;
            this.transferMoneyButton.Click += new System.EventHandler(this.transferMoneyButton_Click);
            // 
            // ShowFinancialStatusButton
            // 
            this.ShowFinancialStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFinancialStatusButton.Location = new System.Drawing.Point(12, 572);
            this.ShowFinancialStatusButton.Name = "ShowFinancialStatusButton";
            this.ShowFinancialStatusButton.Size = new System.Drawing.Size(280, 80);
            this.ShowFinancialStatusButton.TabIndex = 10;
            this.ShowFinancialStatusButton.Text = "Show Financial Status";
            this.ShowFinancialStatusButton.UseVisualStyleBackColor = true;
            this.ShowFinancialStatusButton.Click += new System.EventHandler(this.ShowFinancialStatusButton_Click);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.ShowFinancialStatusButton);
            this.Controls.Add(this.transferMoneyButton);
            this.Controls.Add(this.requestLoanButton);
            this.Controls.Add(this.depositMoneyButton);
            this.Controls.Add(this.logutButton);
            this.Controls.Add(this.updateContactInfoButton);
            this.Controls.Add(this.createDeleteWalletButton);
            this.Controls.Add(this.welcomeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerMainForm";
            this.Text = "ProLa Bank - Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTitle;
        private System.Windows.Forms.Button createDeleteWalletButton;
        private System.Windows.Forms.Button updateContactInfoButton;
        private System.Windows.Forms.Button logutButton;
        private System.Windows.Forms.Button requestLoanButton;
        private System.Windows.Forms.Button depositMoneyButton;
        private System.Windows.Forms.Button transferMoneyButton;
        private System.Windows.Forms.Button ShowFinancialStatusButton;
    }
}