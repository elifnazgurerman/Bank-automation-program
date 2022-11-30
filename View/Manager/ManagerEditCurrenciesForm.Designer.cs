namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    partial class ManagerEditCurrenciesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerEditCurrenciesForm));
            this.currencyListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDBDataSet = new BLM210_ProgramlamaLaboratuvari2_Proje3.SQL.BankDBDataSet();
            this.currencyListTableAdapter = new BLM210_ProgramlamaLaboratuvari2_Proje3.SQL.BankDBDataSetTableAdapters.CurrencyListTableAdapter();
            this.goBackButton = new System.Windows.Forms.Button();
            this.updateCurrencyButton = new System.Windows.Forms.Button();
            this.addCurrencyButton = new System.Windows.Forms.Button();
            this.currencyNameTextBox = new System.Windows.Forms.TextBox();
            this.currencyShortNameTextBox = new System.Windows.Forms.TextBox();
            this.exchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.currencyNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exchangeRateLabel = new System.Windows.Forms.Label();
            this.currencyListDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteCurrencyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.currencyListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyListBindingSource
            // 
            this.currencyListBindingSource.DataMember = "CurrencyList";
            this.currencyListBindingSource.DataSource = this.bankDBDataSet;
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyListTableAdapter
            // 
            this.currencyListTableAdapter.ClearBeforeFill = true;
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(680, 572);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(280, 80);
            this.goBackButton.TabIndex = 12;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // updateCurrencyButton
            // 
            this.updateCurrencyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCurrencyButton.Location = new System.Drawing.Point(966, 486);
            this.updateCurrencyButton.Name = "updateCurrencyButton";
            this.updateCurrencyButton.Size = new System.Drawing.Size(280, 80);
            this.updateCurrencyButton.TabIndex = 13;
            this.updateCurrencyButton.Text = "Update Currency";
            this.updateCurrencyButton.UseVisualStyleBackColor = true;
            this.updateCurrencyButton.Click += new System.EventHandler(this.updateCurrencyButton_Click);
            // 
            // addCurrencyButton
            // 
            this.addCurrencyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCurrencyButton.Location = new System.Drawing.Point(680, 486);
            this.addCurrencyButton.Name = "addCurrencyButton";
            this.addCurrencyButton.Size = new System.Drawing.Size(280, 80);
            this.addCurrencyButton.TabIndex = 14;
            this.addCurrencyButton.Text = "Add Currency";
            this.addCurrencyButton.UseVisualStyleBackColor = true;
            this.addCurrencyButton.Click += new System.EventHandler(this.addCurrencyButton_Click);
            // 
            // currencyNameTextBox
            // 
            this.currencyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyNameTextBox.Location = new System.Drawing.Point(209, 47);
            this.currencyNameTextBox.Name = "currencyNameTextBox";
            this.currencyNameTextBox.Size = new System.Drawing.Size(212, 26);
            this.currencyNameTextBox.TabIndex = 15;
            // 
            // currencyShortNameTextBox
            // 
            this.currencyShortNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyShortNameTextBox.Location = new System.Drawing.Point(209, 79);
            this.currencyShortNameTextBox.Name = "currencyShortNameTextBox";
            this.currencyShortNameTextBox.Size = new System.Drawing.Size(212, 26);
            this.currencyShortNameTextBox.TabIndex = 16;
            // 
            // exchangeRateTextBox
            // 
            this.exchangeRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateTextBox.Location = new System.Drawing.Point(209, 111);
            this.exchangeRateTextBox.Name = "exchangeRateTextBox";
            this.exchangeRateTextBox.Size = new System.Drawing.Size(212, 26);
            this.exchangeRateTextBox.TabIndex = 17;
            // 
            // currencyNameLabel
            // 
            this.currencyNameLabel.AutoSize = true;
            this.currencyNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currencyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyNameLabel.Location = new System.Drawing.Point(31, 50);
            this.currencyNameLabel.Name = "currencyNameLabel";
            this.currencyNameLabel.Size = new System.Drawing.Size(118, 20);
            this.currencyNameLabel.TabIndex = 18;
            this.currencyNameLabel.Text = "Currency Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Currency\'s Short Name";
            // 
            // exchangeRateLabel
            // 
            this.exchangeRateLabel.AutoSize = true;
            this.exchangeRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.exchangeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateLabel.Location = new System.Drawing.Point(31, 114);
            this.exchangeRateLabel.Name = "exchangeRateLabel";
            this.exchangeRateLabel.Size = new System.Drawing.Size(119, 20);
            this.exchangeRateLabel.TabIndex = 20;
            this.exchangeRateLabel.Text = "Exchange Rate";
            this.exchangeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyListDataGridView
            // 
            this.currencyListDataGridView.AllowUserToAddRows = false;
            this.currencyListDataGridView.AllowUserToDeleteRows = false;
            this.currencyListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currencyListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.currencyListDataGridView.Name = "currencyListDataGridView";
            this.currencyListDataGridView.ReadOnly = true;
            this.currencyListDataGridView.RowHeadersWidth = 62;
            this.currencyListDataGridView.RowTemplate.Height = 28;
            this.currencyListDataGridView.Size = new System.Drawing.Size(662, 640);
            this.currencyListDataGridView.TabIndex = 21;
            this.currencyListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currencyListDataGridView_CellContentDoubleClick);
            // 
            // deleteCurrencyButton
            // 
            this.deleteCurrencyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCurrencyButton.Location = new System.Drawing.Point(966, 572);
            this.deleteCurrencyButton.Name = "deleteCurrencyButton";
            this.deleteCurrencyButton.Size = new System.Drawing.Size(280, 80);
            this.deleteCurrencyButton.TabIndex = 22;
            this.deleteCurrencyButton.Text = "Delete Currency";
            this.deleteCurrencyButton.UseVisualStyleBackColor = true;
            this.deleteCurrencyButton.Click += new System.EventHandler(this.deleteCurrencyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currencyNameTextBox);
            this.groupBox1.Controls.Add(this.currencyShortNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.currencyNameLabel);
            this.groupBox1.Controls.Add(this.exchangeRateTextBox);
            this.groupBox1.Controls.Add(this.exchangeRateLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(680, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 468);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency Editor";
            // 
            // EditCurrenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteCurrencyButton);
            this.Controls.Add(this.currencyListDataGridView);
            this.Controls.Add(this.addCurrencyButton);
            this.Controls.Add(this.updateCurrencyButton);
            this.Controls.Add(this.goBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCurrenciesForm";
            this.Text = "ProLa Bank - Manager - Edit Currencies";
            this.Load += new System.EventHandler(this.EditCurrenciesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SQL.BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource currencyListBindingSource;
        private SQL.BankDBDataSetTableAdapters.CurrencyListTableAdapter currencyListTableAdapter;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button updateCurrencyButton;
        private System.Windows.Forms.Button addCurrencyButton;
        private System.Windows.Forms.TextBox currencyNameTextBox;
        private System.Windows.Forms.TextBox currencyShortNameTextBox;
        private System.Windows.Forms.TextBox exchangeRateTextBox;
        private System.Windows.Forms.Label currencyNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exchangeRateLabel;
        private System.Windows.Forms.DataGridView currencyListDataGridView;
        private System.Windows.Forms.Button deleteCurrencyButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}