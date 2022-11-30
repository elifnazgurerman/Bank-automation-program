namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    partial class CustomerLoanListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoanListForm));
            this.LoanListDataGridView = new System.Windows.Forms.DataGridView();
            this.PayLoanButton = new System.Windows.Forms.Button();
            this.RequestLoanButton = new System.Windows.Forms.Button();
            this.LoanAmountLabel = new System.Windows.Forms.Label();
            this.LoanAmountTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanListDataGridView
            // 
            this.LoanListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.LoanListDataGridView.Name = "LoanListDataGridView";
            this.LoanListDataGridView.RowHeadersWidth = 62;
            this.LoanListDataGridView.RowTemplate.Height = 28;
            this.LoanListDataGridView.Size = new System.Drawing.Size(1234, 577);
            this.LoanListDataGridView.TabIndex = 0;
            this.LoanListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanListDataGridView_CellContentDoubleClick);
            // 
            // PayLoanButton
            // 
            this.PayLoanButton.Location = new System.Drawing.Point(1074, 595);
            this.PayLoanButton.Name = "PayLoanButton";
            this.PayLoanButton.Size = new System.Drawing.Size(172, 57);
            this.PayLoanButton.TabIndex = 1;
            this.PayLoanButton.Text = "Pay Loan";
            this.PayLoanButton.UseVisualStyleBackColor = true;
            this.PayLoanButton.Click += new System.EventHandler(this.PayLoanButton_Click);
            // 
            // RequestLoanButton
            // 
            this.RequestLoanButton.Location = new System.Drawing.Point(888, 595);
            this.RequestLoanButton.Name = "RequestLoanButton";
            this.RequestLoanButton.Size = new System.Drawing.Size(180, 57);
            this.RequestLoanButton.TabIndex = 2;
            this.RequestLoanButton.Text = "Request Loan";
            this.RequestLoanButton.UseVisualStyleBackColor = true;
            this.RequestLoanButton.Click += new System.EventHandler(this.RequestLoanButton_Click);
            // 
            // LoanAmountLabel
            // 
            this.LoanAmountLabel.AutoSize = true;
            this.LoanAmountLabel.Location = new System.Drawing.Point(652, 598);
            this.LoanAmountLabel.Name = "LoanAmountLabel";
            this.LoanAmountLabel.Size = new System.Drawing.Size(69, 20);
            this.LoanAmountLabel.TabIndex = 3;
            this.LoanAmountLabel.Text = "Amount:";
            this.LoanAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoanAmountTextBox
            // 
            this.LoanAmountTextBox.Location = new System.Drawing.Point(728, 595);
            this.LoanAmountTextBox.Name = "LoanAmountTextBox";
            this.LoanAmountTextBox.Size = new System.Drawing.Size(154, 26);
            this.LoanAmountTextBox.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 595);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(172, 57);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(728, 626);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(154, 26);
            this.monthTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Months To Pay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerLoanListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LoanAmountTextBox);
            this.Controls.Add(this.LoanAmountLabel);
            this.Controls.Add(this.RequestLoanButton);
            this.Controls.Add(this.PayLoanButton);
            this.Controls.Add(this.LoanListDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerLoanListForm";
            this.Text = "ProLa Bank - Customer - Loan List";
            this.Load += new System.EventHandler(this.CustomerLoanListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoanListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoanListDataGridView;
        private System.Windows.Forms.Button PayLoanButton;
        private System.Windows.Forms.Button RequestLoanButton;
        private System.Windows.Forms.Label LoanAmountLabel;
        private System.Windows.Forms.TextBox LoanAmountTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label label1;
    }
}