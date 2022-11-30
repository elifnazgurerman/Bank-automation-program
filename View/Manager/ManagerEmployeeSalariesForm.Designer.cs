namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    partial class ManagerEmployeeSalariesForm
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
            this.SalariesTextBox = new System.Windows.Forms.TextBox();
            this.SetSalariesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalariesTextBox
            // 
            this.SalariesTextBox.Location = new System.Drawing.Point(13, 13);
            this.SalariesTextBox.Name = "SalariesTextBox";
            this.SalariesTextBox.Size = new System.Drawing.Size(238, 26);
            this.SalariesTextBox.TabIndex = 0;
            // 
            // SetSalariesButton
            // 
            this.SetSalariesButton.Location = new System.Drawing.Point(12, 45);
            this.SetSalariesButton.Name = "SetSalariesButton";
            this.SetSalariesButton.Size = new System.Drawing.Size(239, 68);
            this.SetSalariesButton.TabIndex = 1;
            this.SetSalariesButton.Text = "Set Salaries";
            this.SetSalariesButton.UseVisualStyleBackColor = true;
            this.SetSalariesButton.Click += new System.EventHandler(this.SetSalariesButton_Click);
            // 
            // EmployeeSalariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 125);
            this.Controls.Add(this.SetSalariesButton);
            this.Controls.Add(this.SalariesTextBox);
            this.Name = "EmployeeSalariesForm";
            this.Text = "EmployeeSalariesForm";
            this.Load += new System.EventHandler(this.EmployeeSalariesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalariesTextBox;
        private System.Windows.Forms.Button SetSalariesButton;
    }
}