namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer_Representer
{
    partial class CustomerRepresenterCustomerProcessesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRepresenterCustomerProcessesForm));
            this.WalletListDataGridView = new System.Windows.Forms.DataGridView();
            this.ProcessListDataGridView = new System.Windows.Forms.DataGridView();
            this.ApproveProcessButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectedProcessLabel = new System.Windows.Forms.Label();
            this.SelectedProcessTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WalletListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessListDataGridView)).BeginInit();
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
            this.WalletListDataGridView.Size = new System.Drawing.Size(613, 586);
            this.WalletListDataGridView.TabIndex = 0;
            // 
            // ProcessListDataGridView
            // 
            this.ProcessListDataGridView.AllowUserToAddRows = false;
            this.ProcessListDataGridView.AllowUserToDeleteRows = false;
            this.ProcessListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessListDataGridView.Location = new System.Drawing.Point(631, 12);
            this.ProcessListDataGridView.Name = "ProcessListDataGridView";
            this.ProcessListDataGridView.ReadOnly = true;
            this.ProcessListDataGridView.RowHeadersWidth = 62;
            this.ProcessListDataGridView.RowTemplate.Height = 28;
            this.ProcessListDataGridView.Size = new System.Drawing.Size(615, 586);
            this.ProcessListDataGridView.TabIndex = 1;
            this.ProcessListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessListDataGridView_CellContentDoubleClick);
            // 
            // ApproveProcessButton
            // 
            this.ApproveProcessButton.Location = new System.Drawing.Point(1058, 604);
            this.ApproveProcessButton.Name = "ApproveProcessButton";
            this.ApproveProcessButton.Size = new System.Drawing.Size(188, 44);
            this.ApproveProcessButton.TabIndex = 3;
            this.ApproveProcessButton.Text = "Approve Process";
            this.ApproveProcessButton.UseVisualStyleBackColor = true;
            this.ApproveProcessButton.Click += new System.EventHandler(this.ApproveProcessButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 604);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(188, 44);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectedProcessLabel
            // 
            this.SelectedProcessLabel.AutoSize = true;
            this.SelectedProcessLabel.Location = new System.Drawing.Point(764, 619);
            this.SelectedProcessLabel.Name = "SelectedProcessLabel";
            this.SelectedProcessLabel.Size = new System.Drawing.Size(137, 20);
            this.SelectedProcessLabel.TabIndex = 5;
            this.SelectedProcessLabel.Text = "Selected Process:";
            // 
            // SelectedProcessTextBox
            // 
            this.SelectedProcessTextBox.Location = new System.Drawing.Point(907, 616);
            this.SelectedProcessTextBox.Name = "SelectedProcessTextBox";
            this.SelectedProcessTextBox.ReadOnly = true;
            this.SelectedProcessTextBox.Size = new System.Drawing.Size(100, 26);
            this.SelectedProcessTextBox.TabIndex = 6;
            // 
            // CustomerRepresenterCustomerProcessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.SelectedProcessTextBox);
            this.Controls.Add(this.SelectedProcessLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ApproveProcessButton);
            this.Controls.Add(this.ProcessListDataGridView);
            this.Controls.Add(this.WalletListDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerRepresenterCustomerProcessesForm";
            this.Text = "ProLa Bank - Customer Representer - Customer Processes";
            this.Load += new System.EventHandler(this.CustomerRepresenterCustomerProcessesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WalletListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WalletListDataGridView;
        private System.Windows.Forms.DataGridView ProcessListDataGridView;
        private System.Windows.Forms.Button ApproveProcessButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SelectedProcessLabel;
        private System.Windows.Forms.TextBox SelectedProcessTextBox;
    }
}