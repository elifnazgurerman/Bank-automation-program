namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    partial class CustomerPayLoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayLoanForm));
            this.WalletListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InstallmentIDTextBox = new System.Windows.Forms.TextBox();
            this.InstallmentIDLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.WalletIDTextBox = new System.Windows.Forms.TextBox();
            this.WalletIDLabel = new System.Windows.Forms.Label();
            this.PayLoanButton = new System.Windows.Forms.Button();
            this.LoanListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.WalletListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WalletListDataGridView
            // 
            this.WalletListDataGridView.AllowUserToAddRows = false;
            this.WalletListDataGridView.AllowUserToDeleteRows = false;
            this.WalletListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WalletListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.WalletListDataGridView.Name = "WalletListDataGridView";
            this.WalletListDataGridView.ReadOnly = true;
            this.WalletListDataGridView.RowHeadersWidth = 62;
            this.WalletListDataGridView.RowTemplate.Height = 28;
            this.WalletListDataGridView.Size = new System.Drawing.Size(455, 640);
            this.WalletListDataGridView.TabIndex = 0;
            this.WalletListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WalletListDataGridView_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InstallmentIDTextBox);
            this.groupBox1.Controls.Add(this.InstallmentIDLabel);
            this.groupBox1.Controls.Add(this.AmountTextBox);
            this.groupBox1.Controls.Add(this.AmountLabel);
            this.groupBox1.Controls.Add(this.WalletIDTextBox);
            this.groupBox1.Controls.Add(this.WalletIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(931, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 558);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Loan";
            // 
            // InstallmentIDTextBox
            // 
            this.InstallmentIDTextBox.Location = new System.Drawing.Point(23, 135);
            this.InstallmentIDTextBox.Name = "InstallmentIDTextBox";
            this.InstallmentIDTextBox.ReadOnly = true;
            this.InstallmentIDTextBox.Size = new System.Drawing.Size(265, 26);
            this.InstallmentIDTextBox.TabIndex = 5;
            // 
            // InstallmentIDLabel
            // 
            this.InstallmentIDLabel.AutoSize = true;
            this.InstallmentIDLabel.Location = new System.Drawing.Point(19, 112);
            this.InstallmentIDLabel.Name = "InstallmentIDLabel";
            this.InstallmentIDLabel.Size = new System.Drawing.Size(108, 20);
            this.InstallmentIDLabel.TabIndex = 4;
            this.InstallmentIDLabel.Text = "Installment ID";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(23, 214);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(265, 26);
            this.AmountTextBox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(19, 191);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // WalletIDTextBox
            // 
            this.WalletIDTextBox.Location = new System.Drawing.Point(23, 56);
            this.WalletIDTextBox.Name = "WalletIDTextBox";
            this.WalletIDTextBox.ReadOnly = true;
            this.WalletIDTextBox.Size = new System.Drawing.Size(265, 26);
            this.WalletIDTextBox.TabIndex = 1;
            // 
            // WalletIDLabel
            // 
            this.WalletIDLabel.AutoSize = true;
            this.WalletIDLabel.Location = new System.Drawing.Point(19, 33);
            this.WalletIDLabel.Name = "WalletIDLabel";
            this.WalletIDLabel.Size = new System.Drawing.Size(125, 20);
            this.WalletIDLabel.TabIndex = 0;
            this.WalletIDLabel.Text = "Paying Wallet ID";
            // 
            // PayLoanButton
            // 
            this.PayLoanButton.Location = new System.Drawing.Point(931, 576);
            this.PayLoanButton.Name = "PayLoanButton";
            this.PayLoanButton.Size = new System.Drawing.Size(315, 76);
            this.PayLoanButton.TabIndex = 2;
            this.PayLoanButton.Text = "Pay Loan";
            this.PayLoanButton.UseVisualStyleBackColor = true;
            this.PayLoanButton.Click += new System.EventHandler(this.PayLoanButton_Click);
            // 
            // LoanListDataGridView
            // 
            this.LoanListDataGridView.AllowUserToAddRows = false;
            this.LoanListDataGridView.AllowUserToDeleteRows = false;
            this.LoanListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanListDataGridView.Location = new System.Drawing.Point(473, 12);
            this.LoanListDataGridView.Name = "LoanListDataGridView";
            this.LoanListDataGridView.ReadOnly = true;
            this.LoanListDataGridView.RowHeadersWidth = 62;
            this.LoanListDataGridView.RowTemplate.Height = 28;
            this.LoanListDataGridView.Size = new System.Drawing.Size(452, 640);
            this.LoanListDataGridView.TabIndex = 3;
            this.LoanListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanListDataGridView_CellContentDoubleClick);
            // 
            // CustomerPayLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.LoanListDataGridView);
            this.Controls.Add(this.PayLoanButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WalletListDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerPayLoanForm";
            this.Text = "ProLa Bank - Customer - Pay Loan";
            this.Load += new System.EventHandler(this.CustomerPayLoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WalletListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WalletListDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InstallmentIDTextBox;
        private System.Windows.Forms.Label InstallmentIDLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox WalletIDTextBox;
        private System.Windows.Forms.Label WalletIDLabel;
        private System.Windows.Forms.Button PayLoanButton;
        private System.Windows.Forms.DataGridView LoanListDataGridView;
    }
}