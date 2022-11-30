namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    partial class CustomerDepositWithdrawMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDepositWithdrawMoneyForm));
            this.walletEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.currencyNameTextBox = new System.Windows.Forms.TextBox();
            this.currencyShortNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyNameLabel = new System.Windows.Forms.Label();
            this.exchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.exchangeRateLabel = new System.Windows.Forms.Label();
            this.walletListDataGridView = new System.Windows.Forms.DataGridView();
            this.depositMoneyButton = new System.Windows.Forms.Button();
            this.withdrawMoneyButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.walletEditorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // walletEditorGroupBox
            // 
            this.walletEditorGroupBox.Controls.Add(this.amountTextBox);
            this.walletEditorGroupBox.Controls.Add(this.amountLabel);
            this.walletEditorGroupBox.Controls.Add(this.currencyNameTextBox);
            this.walletEditorGroupBox.Controls.Add(this.currencyShortNameTextBox);
            this.walletEditorGroupBox.Controls.Add(this.label2);
            this.walletEditorGroupBox.Controls.Add(this.currencyNameLabel);
            this.walletEditorGroupBox.Controls.Add(this.exchangeRateTextBox);
            this.walletEditorGroupBox.Controls.Add(this.exchangeRateLabel);
            this.walletEditorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletEditorGroupBox.Location = new System.Drawing.Point(680, 12);
            this.walletEditorGroupBox.Name = "walletEditorGroupBox";
            this.walletEditorGroupBox.Size = new System.Drawing.Size(566, 468);
            this.walletEditorGroupBox.TabIndex = 34;
            this.walletEditorGroupBox.TabStop = false;
            this.walletEditorGroupBox.Text = "Finance Editor";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(209, 143);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(212, 26);
            this.amountTextBox.TabIndex = 21;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(31, 146);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 20);
            this.amountLabel.TabIndex = 22;
            this.amountLabel.Text = "Amount";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyNameTextBox
            // 
            this.currencyNameTextBox.Enabled = false;
            this.currencyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyNameTextBox.Location = new System.Drawing.Point(209, 47);
            this.currencyNameTextBox.Name = "currencyNameTextBox";
            this.currencyNameTextBox.Size = new System.Drawing.Size(212, 26);
            this.currencyNameTextBox.TabIndex = 15;
            // 
            // currencyShortNameTextBox
            // 
            this.currencyShortNameTextBox.Enabled = false;
            this.currencyShortNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyShortNameTextBox.Location = new System.Drawing.Point(209, 79);
            this.currencyShortNameTextBox.Name = "currencyShortNameTextBox";
            this.currencyShortNameTextBox.Size = new System.Drawing.Size(212, 26);
            this.currencyShortNameTextBox.TabIndex = 16;
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
            // exchangeRateTextBox
            // 
            this.exchangeRateTextBox.Enabled = false;
            this.exchangeRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeRateTextBox.Location = new System.Drawing.Point(209, 111);
            this.exchangeRateTextBox.Name = "exchangeRateTextBox";
            this.exchangeRateTextBox.Size = new System.Drawing.Size(212, 26);
            this.exchangeRateTextBox.TabIndex = 17;
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
            // walletListDataGridView
            // 
            this.walletListDataGridView.AllowUserToAddRows = false;
            this.walletListDataGridView.AllowUserToDeleteRows = false;
            this.walletListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.walletListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.walletListDataGridView.Name = "walletListDataGridView";
            this.walletListDataGridView.ReadOnly = true;
            this.walletListDataGridView.RowHeadersWidth = 62;
            this.walletListDataGridView.RowTemplate.Height = 28;
            this.walletListDataGridView.Size = new System.Drawing.Size(662, 640);
            this.walletListDataGridView.TabIndex = 33;
            this.walletListDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.walletListDataGridView_CellContentDoubleClick);
            // 
            // depositMoneyButton
            // 
            this.depositMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositMoneyButton.Location = new System.Drawing.Point(680, 486);
            this.depositMoneyButton.Name = "depositMoneyButton";
            this.depositMoneyButton.Size = new System.Drawing.Size(280, 80);
            this.depositMoneyButton.TabIndex = 32;
            this.depositMoneyButton.Text = "Deposit Money";
            this.depositMoneyButton.UseVisualStyleBackColor = true;
            this.depositMoneyButton.Click += new System.EventHandler(this.depositMoneyButton_Click);
            // 
            // withdrawMoneyButton
            // 
            this.withdrawMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawMoneyButton.Location = new System.Drawing.Point(966, 486);
            this.withdrawMoneyButton.Name = "withdrawMoneyButton";
            this.withdrawMoneyButton.Size = new System.Drawing.Size(280, 80);
            this.withdrawMoneyButton.TabIndex = 31;
            this.withdrawMoneyButton.Text = "Withdraw Money";
            this.withdrawMoneyButton.UseVisualStyleBackColor = true;
            this.withdrawMoneyButton.Click += new System.EventHandler(this.withdrawMoneyButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(680, 572);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(280, 80);
            this.goBackButton.TabIndex = 30;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // DepositWithdrawMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.walletEditorGroupBox);
            this.Controls.Add(this.walletListDataGridView);
            this.Controls.Add(this.depositMoneyButton);
            this.Controls.Add(this.withdrawMoneyButton);
            this.Controls.Add(this.goBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositWithdrawMoneyForm";
            this.Text = "ProLa Bank - Customer - Deposit Withdraw Money";
            this.Load += new System.EventHandler(this.DepositWithdrawMoneyForm_Load);
            this.walletEditorGroupBox.ResumeLayout(false);
            this.walletEditorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox walletEditorGroupBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox currencyNameTextBox;
        private System.Windows.Forms.TextBox currencyShortNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currencyNameLabel;
        private System.Windows.Forms.TextBox exchangeRateTextBox;
        private System.Windows.Forms.Label exchangeRateLabel;
        private System.Windows.Forms.DataGridView walletListDataGridView;
        private System.Windows.Forms.Button depositMoneyButton;
        private System.Windows.Forms.Button withdrawMoneyButton;
        private System.Windows.Forms.Button goBackButton;
    }
}