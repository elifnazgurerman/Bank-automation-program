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
    public partial class CustomerPayLoanForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int selectedInstallmentID = 0;

        decimal payAmount = 0;

        public CustomerPayLoanForm()
        {
            InitializeComponent();
        }

        private void CustomerPayLoanForm_Load(object sender, EventArgs e)
        {
            var walletList =
                from wallet in bank.WalletLists
                where wallet.user_id == Supporting_Files.Variables.userID
                select wallet;

            WalletListDataGridView.DataSource = walletList;

            var loanList =
                from loan in bank.LoanInstallmentLists
                where loan.loan_id == Supporting_Files.Variables.selectedLoanID
                select loan;

            LoanListDataGridView.DataSource = loanList;
        }

        private void WalletListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Supporting_Files.Variables.selectedWalletID = Convert.ToInt32(WalletListDataGridView.CurrentRow.Cells[0].Value);

            WalletIDTextBox.Text = Supporting_Files.Variables.selectedWalletID.ToString();
        }

        private void LoanListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedInstallmentID = Convert.ToInt32(LoanListDataGridView.CurrentRow.Cells[0].Value);

            InstallmentIDTextBox.Text = selectedInstallmentID.ToString();

            var tempLoanList =
                from loan in bank.LoanLists
                where loan.loan_id == Supporting_Files.Variables.selectedLoanID
                select loan;

            decimal interestRate = 0;

            if (Convert.ToDateTime(LoanListDataGridView.CurrentRow.Cells[2].Value) > Supporting_Files.Variables.currentDate)
            {
                interestRate = 1;
            } 
            
            else if (Convert.ToDateTime(LoanListDataGridView.CurrentRow.Cells[2].Value) > Supporting_Files.Variables.currentDate)
            {
                interestRate = tempLoanList.FirstOrDefault().interest_rate;
            }

            else
            {
                interestRate = tempLoanList.FirstOrDefault().delayed_interest_rate;
            }

            payAmount = Convert.ToDecimal(LoanListDataGridView.CurrentRow.Cells[0].Value) * interestRate;

            AmountTextBox.Text = payAmount.ToString();

        }

        private void PayLoanButton_Click(object sender, EventArgs e)
        {
            if (Supporting_Files.Variables.selectedLoanID > 0 && selectedInstallmentID > 0 && payAmount > 0)
            {
                SQL.ProcessList newProcess = new SQL.ProcessList();
                newProcess.process_type = 7;
                newProcess.amount = payAmount;
                newProcess.process_owner = Supporting_Files.Variables.userID;
                newProcess.sending_wallet = Supporting_Files.Variables.selectedWalletID;
                newProcess.target_wallet = selectedInstallmentID;
                newProcess.is_approved = true;
                newProcess.process_date = Supporting_Files.Variables.currentDate;
                bank.ProcessLists.InsertOnSubmit(newProcess);
                bank.SubmitChanges();
            }
        }
    }
}
