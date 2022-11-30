using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLM210_ProgramlamaLaboratuvari2_Proje3
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void showFinancialStatusButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerFinancialStatusForm();
            form.Show();
        }

        private void editCurrenciesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Manager.ManagerEditCurrenciesForm();
            form.Show();
        }

        private void setCreditInterestRatesButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerSetCreditInterestRatesForm();
            form.Show();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerAddCustomerForm();
            form.Show();
        }

        private void advanceSystemButton_Click(object sender, EventArgs e)
        {
            SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

            var processList =
                from process in bank.ProcessLists
                orderby process.process_id
                select process;

            foreach (var process in processList)
            {
                if (process.process_date == Supporting_Files.Variables.currentDate)
                {
                    switch (process.process_type)
                    {
                        case 1:
                            var walletDepositQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == process.target_wallet
                                select wallet;

                            foreach (var wallet in walletDepositQuery)
                            {
                                wallet.wallet_weight += process.amount;
                            }

                            bank.SubmitChanges();

                            break;

                        case 2:
                            var walletWithdrawQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == process.sending_wallet
                                select wallet;

                            foreach (var wallet in walletWithdrawQuery)
                            {
                                wallet.wallet_weight -= process.amount;
                            }

                            bank.SubmitChanges();

                            break;

                        case 3:
                            if (!process.is_deadlock ?? false)
                            {
                                var walletSendingTransferQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == process.sending_wallet
                                select wallet;

                                foreach (var wallet in walletSendingTransferQuery)
                                {
                                    var currencyList =
                                        from currency in bank.CurrencyLists
                                        where currency.currency_id == wallet.currency_id
                                        select currency;

                                    wallet.wallet_weight -= process.amount * Convert.ToDecimal(currencyList.FirstOrDefault().exchange_rate);
                                }

                                var walletTargetTransferQuery =
                                    from wallet in bank.WalletLists
                                    where wallet.wallet_id == process.target_wallet
                                    select wallet;

                                foreach (var wallet in walletTargetTransferQuery)
                                {
                                    var currencyList =
                                        from currency in bank.CurrencyLists
                                        where currency.currency_id == wallet.currency_id
                                        select currency;

                                    wallet.wallet_weight += process.amount / Convert.ToDecimal(currencyList.FirstOrDefault().exchange_rate);
                                    wallet.accepts_transactions = false;
                                }

                                bank.SubmitChanges();
                            }

                            break;

                        case 4:
                            var walletCreateQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == process.sending_wallet
                                select wallet;

                            foreach (var wallet in walletCreateQuery)
                            {
                                if (process.is_approved ?? false)
                                {
                                    wallet.is_active = true;
                                }

                                else
                                {
                                    bank.WalletLists.DeleteOnSubmit(wallet);
                                }
                            }

                            bank.SubmitChanges();

                            break;

                        case 5:
                            var walletDeleteQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == process.sending_wallet
                                select wallet;

                            foreach (var wallet in walletDeleteQuery)
                            {
                                var processDeleteQuery =
                                    from deletedProcess in bank.ProcessLists
                                    where deletedProcess.sending_wallet == wallet.wallet_id || deletedProcess.target_wallet == wallet.wallet_id
                                    select deletedProcess;

                                foreach (var temp in processDeleteQuery)
                                {
                                    bank.ProcessLists.DeleteOnSubmit(temp);
                                }

                                bank.WalletLists.DeleteOnSubmit(wallet);
                            }

                            bank.SubmitChanges();

                            break;

                        case 6:
                            var requestLoanSendingTransferQuery =
                            from wallet in bank.WalletLists
                            where wallet.wallet_id == 29
                            select wallet;

                            foreach (var wallet in requestLoanSendingTransferQuery)
                            {
                                wallet.wallet_weight -= process.amount;
                            }

                            SQL.WalletList newWallet = new SQL.WalletList();
                            newWallet.user_id = process.process_owner ?? 29;
                            newWallet.currency_id = 20;
                            newWallet.wallet_weight = process.amount;
                            newWallet.accepts_transactions = true;
                            newWallet.is_active = true;
                            bank.WalletLists.InsertOnSubmit(newWallet);

                            var interestList =
                                from interest in bank.InterestRates
                                select interest;

                            SQL.LoanList newLoan = new SQL.LoanList();
                            newLoan.user_id = process.process_owner ?? 29;
                            newLoan.amount = process.amount;
                            newLoan.interest_rate = interestList.FirstOrDefault().default_interest_rate;
                            newLoan.delayed_interest_rate = interestList.FirstOrDefault().delayed_interest_rate;
                            newLoan.months_to_pay = Supporting_Files.Variables.monthsToPay;
                            bank.LoanLists.InsertOnSubmit(newLoan);

                            bank.SubmitChanges();

                            var loanList =
                                from loan in bank.LoanLists
                                select loan;

                            DateTime lastPayday = Supporting_Files.Variables.currentDate;

                            for (int i = 0; i == newLoan.months_to_pay; i++)
                            {
                                SQL.LoanInstallmentList newLoanInstallment = new SQL.LoanInstallmentList();
                                newLoanInstallment.loan_id = loanList.OrderByDescending(loan => loan.loan_id).FirstOrDefault().loan_id;
                                newLoanInstallment.amount = loanList.OrderByDescending(loan => loan.loan_id).FirstOrDefault().amount;
                                lastPayday = lastPayday.AddMonths(1);
                                newLoanInstallment.payday = lastPayday;
                                bank.LoanInstallmentLists.InsertOnSubmit(newLoanInstallment);
                                bank.SubmitChanges();
                            }

                            break;

                        case 7:
                            var payLoanTargetTransferQuery =
                                from wallet in bank.WalletLists
                                where wallet.wallet_id == 29
                                select wallet;

                            foreach (var wallet in payLoanTargetTransferQuery)
                            {
                                wallet.wallet_weight += process.amount;
                            }

                            bank.SubmitChanges();

                            break;
                    }
                }
            }

            var refreshWalletQuery =
                from wallet in bank.WalletLists
                select wallet;

            foreach (var wallet in refreshWalletQuery)
            {
                wallet.accepts_transactions = true;
            }

            bank.SubmitChanges();

            Supporting_Files.Variables.currentDate.AddMonths(1);

            SQL.Date newDate = new SQL.Date();
            newDate.currentDate = Supporting_Files.Variables.currentDate.AddMonths(1);
            Supporting_Files.Variables.currentDate = newDate.currentDate;
            bank.Dates.InsertOnSubmit(newDate);

            var employees =
                from user in bank.UserLists
                where user.user_type == 3
                select user;

            var salaries =
                from salary in bank.SalariesLists
                where salary.user_type == 3
                select salary;

            SQL.ProcessList newProcess = new SQL.ProcessList();
            newProcess.process_type = 2;
            newProcess.sending_wallet = 29;
            newProcess.amount = employees.Count() * salaries.FirstOrDefault().salary;
            newProcess.process_owner = 1;
            newProcess.process_date = Supporting_Files.Variables.currentDate;
            bank.ProcessLists.InsertOnSubmit(newProcess);

            bank.SubmitChanges();
        }

        private void viewAllTransactionsButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerViewAllTransactionsForm();
            form.Show();
        }

        private void analyzeForDeadlocksButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Supporting_Files.Variables.userID = -1;
            Supporting_Files.Variables.representerID = -1;
            Form form = new LoginForm();
            form.Show();
        }

        private void SetSalariesButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerEmployeeSalariesForm();
            form.Show();
        }
    }
}
