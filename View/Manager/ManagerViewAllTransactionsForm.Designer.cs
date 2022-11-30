namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    partial class ManagerViewAllTransactionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerViewAllTransactionsForm));
            this.bankDBDataSet = new BLM210_ProgramlamaLaboratuvari2_Proje3.SQL.BankDBDataSet();
            this.processListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processListTableAdapter = new BLM210_ProgramlamaLaboratuvari2_Proje3.SQL.BankDBDataSetTableAdapters.ProcessListTableAdapter();
            this.processListDataGridView = new System.Windows.Forms.DataGridView();
            this.processListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.processidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendingwalletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetwalletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_wallet_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sending_wallet_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_deadlock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processListBindingSource
            // 
            this.processListBindingSource.DataMember = "ProcessList";
            this.processListBindingSource.DataSource = this.bankDBDataSet;
            // 
            // processListTableAdapter
            // 
            this.processListTableAdapter.ClearBeforeFill = true;
            // 
            // processListDataGridView
            // 
            this.processListDataGridView.AllowUserToAddRows = false;
            this.processListDataGridView.AllowUserToDeleteRows = false;
            this.processListDataGridView.AutoGenerateColumns = false;
            this.processListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processidDataGridViewTextBoxColumn,
            this.sendingwalletDataGridViewTextBoxColumn,
            this.targetwalletDataGridViewTextBoxColumn,
            this.process_name,
            this.amountDataGridViewTextBoxColumn,
            this.target_wallet_weight,
            this.sending_wallet_weight,
            this.processdateDataGridViewTextBoxColumn,
            this.is_deadlock});
            this.processListDataGridView.DataSource = this.processListBindingSource1;
            this.processListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.processListDataGridView.Name = "processListDataGridView";
            this.processListDataGridView.ReadOnly = true;
            this.processListDataGridView.RowHeadersWidth = 62;
            this.processListDataGridView.RowTemplate.Height = 28;
            this.processListDataGridView.Size = new System.Drawing.Size(1234, 640);
            this.processListDataGridView.TabIndex = 0;
            // 
            // processListBindingSource1
            // 
            this.processListBindingSource1.DataMember = "ProcessList";
            this.processListBindingSource1.DataSource = this.bankDBDataSet;
            // 
            // processidDataGridViewTextBoxColumn
            // 
            this.processidDataGridViewTextBoxColumn.DataPropertyName = "process_id";
            this.processidDataGridViewTextBoxColumn.HeaderText = "Process ID";
            this.processidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.processidDataGridViewTextBoxColumn.Name = "processidDataGridViewTextBoxColumn";
            this.processidDataGridViewTextBoxColumn.ReadOnly = true;
            this.processidDataGridViewTextBoxColumn.Width = 150;
            // 
            // sendingwalletDataGridViewTextBoxColumn
            // 
            this.sendingwalletDataGridViewTextBoxColumn.DataPropertyName = "sending_wallet";
            this.sendingwalletDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.sendingwalletDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sendingwalletDataGridViewTextBoxColumn.Name = "sendingwalletDataGridViewTextBoxColumn";
            this.sendingwalletDataGridViewTextBoxColumn.ReadOnly = true;
            this.sendingwalletDataGridViewTextBoxColumn.Width = 150;
            // 
            // targetwalletDataGridViewTextBoxColumn
            // 
            this.targetwalletDataGridViewTextBoxColumn.DataPropertyName = "target_wallet";
            this.targetwalletDataGridViewTextBoxColumn.HeaderText = "Target";
            this.targetwalletDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.targetwalletDataGridViewTextBoxColumn.Name = "targetwalletDataGridViewTextBoxColumn";
            this.targetwalletDataGridViewTextBoxColumn.ReadOnly = true;
            this.targetwalletDataGridViewTextBoxColumn.Width = 150;
            // 
            // process_name
            // 
            this.process_name.HeaderText = "Process Name";
            this.process_name.MinimumWidth = 8;
            this.process_name.Name = "process_name";
            this.process_name.ReadOnly = true;
            this.process_name.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // target_wallet_weight
            // 
            this.target_wallet_weight.HeaderText = "Target Balance";
            this.target_wallet_weight.MinimumWidth = 8;
            this.target_wallet_weight.Name = "target_wallet_weight";
            this.target_wallet_weight.ReadOnly = true;
            this.target_wallet_weight.Width = 150;
            // 
            // sending_wallet_weight
            // 
            this.sending_wallet_weight.HeaderText = "Sender Balance";
            this.sending_wallet_weight.MinimumWidth = 8;
            this.sending_wallet_weight.Name = "sending_wallet_weight";
            this.sending_wallet_weight.ReadOnly = true;
            this.sending_wallet_weight.Width = 150;
            // 
            // processdateDataGridViewTextBoxColumn
            // 
            this.processdateDataGridViewTextBoxColumn.DataPropertyName = "process_date";
            this.processdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.processdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.processdateDataGridViewTextBoxColumn.Name = "processdateDataGridViewTextBoxColumn";
            this.processdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.processdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // is_deadlock
            // 
            this.is_deadlock.DataPropertyName = "is_deadlock";
            this.is_deadlock.HeaderText = "Deadlock Status";
            this.is_deadlock.MinimumWidth = 8;
            this.is_deadlock.Name = "is_deadlock";
            this.is_deadlock.ReadOnly = true;
            this.is_deadlock.Width = 150;
            // 
            // ManagerViewAllTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.processListDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerViewAllTransactionsForm";
            this.Text = "ProLa Bank - Manager - View All Transactions";
            this.Load += new System.EventHandler(this.ManagerViewAllTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SQL.BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource processListBindingSource;
        private SQL.BankDBDataSetTableAdapters.ProcessListTableAdapter processListTableAdapter;
        private System.Windows.Forms.DataGridView processListDataGridView;
        private System.Windows.Forms.BindingSource processListBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn processidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendingwalletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetwalletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_wallet_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn sending_wallet_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn processdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_deadlock;
    }
}