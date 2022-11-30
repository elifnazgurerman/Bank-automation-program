namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    partial class ManagerSetCreditInterestRatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerSetCreditInterestRatesForm));
            this.updateInterestRateButton = new System.Windows.Forms.Button();
            this.creditInterestRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.delayedInterestRateLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.delayedInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.creditInterestRatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateInterestRateButton
            // 
            this.updateInterestRateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInterestRateButton.Location = new System.Drawing.Point(12, 278);
            this.updateInterestRateButton.Name = "updateInterestRateButton";
            this.updateInterestRateButton.Size = new System.Drawing.Size(280, 80);
            this.updateInterestRateButton.TabIndex = 15;
            this.updateInterestRateButton.Text = "Update Interest Rate";
            this.updateInterestRateButton.UseVisualStyleBackColor = true;
            this.updateInterestRateButton.Click += new System.EventHandler(this.updateInterestRateButton_Click);
            // 
            // creditInterestRatesGroupBox
            // 
            this.creditInterestRatesGroupBox.Controls.Add(this.delayedInterestRateLabel);
            this.creditInterestRatesGroupBox.Controls.Add(this.interestRateLabel);
            this.creditInterestRatesGroupBox.Controls.Add(this.delayedInterestRateTextBox);
            this.creditInterestRatesGroupBox.Controls.Add(this.interestRateTextBox);
            this.creditInterestRatesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.creditInterestRatesGroupBox.Name = "creditInterestRatesGroupBox";
            this.creditInterestRatesGroupBox.Size = new System.Drawing.Size(280, 260);
            this.creditInterestRatesGroupBox.TabIndex = 14;
            this.creditInterestRatesGroupBox.TabStop = false;
            this.creditInterestRatesGroupBox.Text = "Credit Interest Rates";
            // 
            // delayedInterestRateLabel
            // 
            this.delayedInterestRateLabel.AutoSize = true;
            this.delayedInterestRateLabel.Location = new System.Drawing.Point(6, 147);
            this.delayedInterestRateLabel.Name = "delayedInterestRateLabel";
            this.delayedInterestRateLabel.Size = new System.Drawing.Size(165, 20);
            this.delayedInterestRateLabel.TabIndex = 3;
            this.delayedInterestRateLabel.Text = "Delayed Interest Rate";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(6, 52);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(103, 20);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // delayedInterestRateTextBox
            // 
            this.delayedInterestRateTextBox.Location = new System.Drawing.Point(6, 170);
            this.delayedInterestRateTextBox.Name = "delayedInterestRateTextBox";
            this.delayedInterestRateTextBox.Size = new System.Drawing.Size(268, 26);
            this.delayedInterestRateTextBox.TabIndex = 1;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(6, 75);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(268, 26);
            this.interestRateTextBox.TabIndex = 0;
            // 
            // ManagerSetCreditInterestRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 366);
            this.Controls.Add(this.updateInterestRateButton);
            this.Controls.Add(this.creditInterestRatesGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerSetCreditInterestRatesForm";
            this.Text = "ProLa Bank - Manager - Set Credit Interest Rates";
            this.creditInterestRatesGroupBox.ResumeLayout(false);
            this.creditInterestRatesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateInterestRateButton;
        private System.Windows.Forms.GroupBox creditInterestRatesGroupBox;
        private System.Windows.Forms.Label delayedInterestRateLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox delayedInterestRateTextBox;
    }
}