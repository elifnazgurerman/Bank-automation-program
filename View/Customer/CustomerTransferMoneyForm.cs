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
    public partial class CustomerTransferMoneyForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int walletID = 0;
        int currencyID = 0;
        decimal maxTransferAmount = 0;
        bool didAddCurrencyNameRow = false;

        public CustomerTransferMoneyForm()
        {
            InitializeComponent();
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
                walletListDataGridView.Rows[rowCount].Cells["currencyName"].Value = temp.First().currency_name;
                rowCount += 1;
            }
        }

        private void CustomerTransferMoneyForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void walletListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tempWalletId = walletListDataGridView.CurrentRow.Cells[0].Value.ToString();
            walletID = int.Parse(tempWalletId);

            string tempAmount = walletListDataGridView.CurrentRow.Cells[3].Value.ToString();
            maxTransferAmount = Convert.ToDecimal(tempAmount);

            string tempCurrencyId = walletListDataGridView.CurrentRow.Cells[2].Value.ToString();
            currencyID = int.Parse(tempCurrencyId);

            var tempCurrency =
                from currency in bank.CurrencyLists
                where currency.currency_id == currencyID
                select currency;

            currencyNameTextBox.Text = tempCurrency.FirstOrDefault().currency_name;
            currencyShortNameTextBox.Text = tempCurrency.FirstOrDefault().currency_shortname;
            exchangeRateTextBox.Text = tempCurrency.FirstOrDefault().exchange_rate.ToString();
            amountTextBox.Text = 0.ToString();
        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            if (walletID != 0)
            {
                if (maxTransferAmount >= Convert.ToDecimal(amountTextBox.Text))
                {
                    var sendingWallet =
                        from wallet in bank.WalletLists
                        where wallet.wallet_id == walletID
                        select wallet;

                    bool acceptsTransactions = sendingWallet.FirstOrDefault().accepts_transactions ?? true;

                    SQL.ProcessList newProcess = new SQL.ProcessList();
                    newProcess.process_type = 3;
                    newProcess.sending_wallet = sendingWallet.FirstOrDefault().wallet_id;
                    newProcess.target_wallet = Convert.ToInt32(targetWalletIDTextBox.Text);
                    newProcess.amount = Convert.ToDecimal(amountTextBox.Text);
                    newProcess.is_approved = true;
                    newProcess.is_deadlock = !(acceptsTransactions);
                    newProcess.process_owner = Supporting_Files.Variables.userID;
                    newProcess.process_date = Supporting_Files.Variables.currentDate;
                    bank.ProcessLists.InsertOnSubmit(newProcess);

                    var targetWallet =
                        from wallet in bank.WalletLists
                        where wallet.wallet_id == Convert.ToInt32(targetWalletIDTextBox.Text)
                        select wallet;

                    foreach (var wallet in targetWallet)
                    {
                        wallet.accepts_transactions = false;
                    }

                    try
                    {
                        bank.SubmitChanges();
                    }

                    catch
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a proper amount.");
                }
            }

            else
            {
                MessageBox.Show("Please select sending wallet.");
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
