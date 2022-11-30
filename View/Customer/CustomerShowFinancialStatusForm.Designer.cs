namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    partial class CustomerShowFinancialStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerShowFinancialStatusForm));
            this.FinancialStatusDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialStatusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FinancialStatusDataGridView
            // 
            this.FinancialStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinancialStatusDataGridView.Location = new System.Drawing.Point(12, 12);
            this.FinancialStatusDataGridView.Name = "FinancialStatusDataGridView";
            this.FinancialStatusDataGridView.RowHeadersWidth = 62;
            this.FinancialStatusDataGridView.RowTemplate.Height = 28;
            this.FinancialStatusDataGridView.Size = new System.Drawing.Size(1234, 640);
            this.FinancialStatusDataGridView.TabIndex = 0;
            // 
            // CustomerShowFinancialStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.FinancialStatusDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerShowFinancialStatusForm";
            this.Text = "ProLa Bank - Customer - Show Financial Status";
            this.Load += new System.EventHandler(this.CustomerShowFinancialStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinancialStatusDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FinancialStatusDataGridView;
    }
}