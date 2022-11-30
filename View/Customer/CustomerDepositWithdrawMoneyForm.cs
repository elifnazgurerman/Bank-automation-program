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
    public partial class CustomerDepositWithdrawMoneyForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int walletId = 0;
        int currencyId = 0;
        decimal maxWithdrawAmount = 0;
        bool didAddCurrencyNameRow = false;

        public CustomerDepositWithdrawMoneyForm()
        {
            InitializeComponent();
        }

        private void DepositWithdrawMoneyForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            if (didAddCurrencyNameRow)
            {
                walletListDataGridView.Columns.RemoveAt(7);
            }
            var query =
                from wallet in bank.WalletLists
                where wallet.user_id == Supporting_Files.Variables.userID
                select wallet;

            walletListDataGridView.DataSource = query;
            walletListDataGridView.Columns[0].Visible = false;
            walletListDataGridView.Columns[1].Visible = false;
            walletListDataGridView.Columns[2].Visible = false;
            walletListDataGridView.Columns[3].HeaderText = "Amount";
            walletListDataGridView.Columns[4].Visible = false;
            walletListDataGridView.Columns[5].Visible = false;
            walletListDataGridView.Columns[6].Visible = false;
            walletListDataGridView.Columns[7].Visible = false;

            walletListDataGridView.Columns.Add("currencyName", "Currency Name");
            didAddCurrencyNameRow = true;

            int rowCount = 0;
            foreach (var wallet in query)
            {
                var temp =
                    from currency in bank.CurrencyLists
                    where wallet.currency_id == currency.currency_id
                    select currency;
                walletListDataGridView.Rows[rowCount].Cells["currencyName"].Value = temp.FirstOrDefault().currency_name;
                rowCount += 1;
            }
        }

        private void walletListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tempWalletId = walletListDataGridView.CurrentRow.Cells[0].Value.ToString();
            walletId = int.Parse(tempWalletId);

            string tempAmount = walletListDataGridView.CurrentRow.Cells[3].Value.ToString();
            maxWithdrawAmount = Convert.ToDecimal(tempAmount);

            string tempCurrencyId = walletListDataGridView.CurrentRow.Cells[2].Value.ToString();
            currencyId = int.Parse(tempCurrencyId);

            var tempCurrency =
                from currency in bank.CurrencyLists
                where currency.currency_id == currencyId
                select currency;

            currencyNameTextBox.Text = tempCurrency.FirstOrDefault().currency_name;
            currencyShortNameTextBox.Text = tempCurrency.FirstOrDefault().currency_shortname;
            exchangeRateTextBox.Text = tempCurrency.FirstOrDefault().exchange_rate.ToString();
            amountTextBox.Text = 0.ToString();
        }

        private void depositMoneyButton_Click(object sender, EventArgs e)
        {
            if (walletId != 0)
            {
                if (amountTextBox.Text.Length > 0)
                {
                    var selectedWallet =
                        from wallet in bank.WalletLists
                        where wallet.wallet_id == walletId
                        select wallet;

                    SQL.ProcessList newProcess = new SQL.ProcessList();
                    newProcess.process_type = 1;
                    newProcess.target_wallet = selectedWallet.FirstOrDefault().wallet_id;
                    newProcess.amount = Convert.ToDecimal(amountTextBox.Text);
                    newProcess.process_owner = Supporting_Files.Variables.userID;
                    newProcess.is_approved = true;
                    newProcess.process_date = Supporting_Files.Variables.currentDate;
                    bank.ProcessLists.InsertOnSubmit(newProcess);

                    foreach (var wallet in selectedWallet)
                    {
                        wallet.accepts_transactions = false;
                    }

                    bank.SubmitChanges();
                }

                else
                {
                    MessageBox.Show("Please enter requested withdraw amount.");
                }
            }

            else
            {
                MessageBox.Show("Please select a wallet from the list.");
            }
        }

        private void withdrawMoneyButton_Click(object sender, EventArgs e)
        {
            if (walletId != 0)
            {
                if (amountTextBox.Text.Length > 0)
                {
                    decimal tempAmount = Convert.ToDecimal(amountTextBox.Text);

                    if (tempAmount > maxWithdrawAmount)
                    {
                        MessageBox.Show("Requested amount exceeds maximum accessible.");
                    }

                    else
                    {
                        var selectedWallet =
                            from wallet in bank.WalletLists
                            where wallet.wallet_id == walletId
                            select wallet;

                        SQL.ProcessList newProcess = new SQL.ProcessList();
                        newProcess.process_type = 2;
                        newProcess.sending_wallet = selectedWallet.FirstOrDefault().wallet_id;
                        newProcess.amount = tempAmount;
                        newProcess.process_owner = Supporting_Files.Variables.userID;
                        newProcess.process_date = Supporting_Files.Variables.currentDate;
                        bank.ProcessLists.InsertOnSubmit(newProcess);
                        bank.SubmitChanges();
                    }
                }

                else
                {
                    MessageBox.Show("Please enter requested withdraw amount.");
                }
            }

            else
            {
                MessageBox.Show("Please select a wallet from the list.");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new CustomerMainForm();
            form.Show();
        }
    }
}
