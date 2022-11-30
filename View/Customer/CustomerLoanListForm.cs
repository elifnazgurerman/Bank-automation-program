using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer
{
    public partial class CustomerLoanListForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerLoanListForm()
        {
            InitializeComponent();
        }

        private void CustomerLoanListForm_Load(object sender, EventArgs e)
        {
            var loanList = 
                from loan in bank.LoanLists
                where loan.user_id == Supporting_Files.Variables.userID
                select loan;

            LoanListDataGridView.DataSource = loanList;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new CustomerMainForm();
            form.Show();
        }

        private void LoanListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Supporting_Files.Variables.selectedLoanID = Convert.ToInt32(LoanListDataGridView.CurrentRow.Cells[0].Value);
        }

        private void RequestLoanButton_Click(object sender, EventArgs e)
        {
            if (LoanAmountTextBox.Text.Length > 0)
            {
                SQL.ProcessList newProcess = new SQL.ProcessList();
                newProcess.process_type = 6;
                newProcess.amount = Convert.ToDecimal(LoanAmountTextBox.Text);
                newProcess.process_owner = Supporting_Files.Variables.userID;
                newProcess.is_approved = false;
                newProcess.process_date = Supporting_Files.Variables.currentDate;
                Supporting_Files.Variables.monthsToPay = Convert.ToInt32(monthTextBox.Text);
                bank.ProcessLists.InsertOnSubmit(newProcess);
                bank.SubmitChanges();
            }
            
            else
            {
                MessageBox.Show("Please enter your desired amount.");
            }
        }

        private void PayLoanButton_Click(object sender, EventArgs e)
        {
            if (Supporting_Files.Variables.selectedLoanID != -1)
            {
                this.Close();
                Form form = new CustomerPayLoanForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Please select a loan from the list.");
            }
        }
    }
}
