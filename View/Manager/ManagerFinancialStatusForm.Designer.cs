namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    partial class ManagerFinancialStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerFinancialStatusForm));
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.OutcomeTextBox = new System.Windows.Forms.TextBox();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.ProfitTextBox = new System.Windows.Forms.TextBox();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.TotalBalanceTextBox = new System.Windows.Forms.TextBox();
            this.TotalBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Location = new System.Drawing.Point(8, 9);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(62, 20);
            this.IncomeLabel.TabIndex = 0;
            this.IncomeLabel.Text = "Income";
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(12, 32);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.ReadOnly = true;
            this.IncomeTextBox.Size = new System.Drawing.Size(160, 26);
            this.IncomeTextBox.TabIndex = 1;
            // 
            // OutcomeTextBox
            // 
            this.OutcomeTextBox.Location = new System.Drawing.Point(12, 102);
            this.OutcomeTextBox.Name = "OutcomeTextBox";
            this.OutcomeTextBox.ReadOnly = true;
            this.OutcomeTextBox.Size = new System.Drawing.Size(160, 26);
            this.OutcomeTextBox.TabIndex = 3;
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Location = new System.Drawing.Point(8, 79);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(74, 20);
            this.OutcomeLabel.TabIndex = 2;
            this.OutcomeLabel.Text = "Outcome";
            // 
            // ProfitTextBox
            // 
            this.ProfitTextBox.Location = new System.Drawing.Point(12, 177);
            this.ProfitTextBox.Name = "ProfitTextBox";
            this.ProfitTextBox.ReadOnly = true;
            this.ProfitTextBox.Size = new System.Drawing.Size(160, 26);
            this.ProfitTextBox.TabIndex = 5;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(12, 154);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(46, 20);
            this.ProfitLabel.TabIndex = 4;
            this.ProfitLabel.Text = "Profit";
            // 
            // TotalBalanceTextBox
            // 
            this.TotalBalanceTextBox.Location = new System.Drawing.Point(8, 252);
            this.TotalBalanceTextBox.Name = "TotalBalanceTextBox";
            this.TotalBalanceTextBox.ReadOnly = true;
            this.TotalBalanceTextBox.Size = new System.Drawing.Size(160, 26);
            this.TotalBalanceTextBox.TabIndex = 7;
            // 
            // TotalBalanceLabel
            // 
            this.TotalBalanceLabel.AutoSize = true;
            this.TotalBalanceLabel.Location = new System.Drawing.Point(8, 229);
            this.TotalBalanceLabel.Name = "TotalBalanceLabel";
            this.TotalBalanceLabel.Size = new System.Drawing.Size(106, 20);
            this.TotalBalanceLabel.TabIndex = 6;
            this.TotalBalanceLabel.Text = "Total Balance";
            // 
            // ManagerFinancialStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 294);
            this.Controls.Add(this.TotalBalanceTextBox);
            this.Controls.Add(this.TotalBalanceLabel);
            this.Controls.Add(this.ProfitTextBox);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.OutcomeTextBox);
            this.Controls.Add(this.OutcomeLabel);
            this.Controls.Add(this.IncomeTextBox);
            this.Controls.Add(this.IncomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerFinancialStatusForm";
            this.Text = "ManagerFinancialStatusForm";
            this.Load += new System.EventHandler(this.ManagerFinancialStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.TextBox OutcomeTextBox;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.TextBox ProfitTextBox;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.TextBox TotalBalanceTextBox;
        private System.Windows.Forms.Label TotalBalanceLabel;
    }
}