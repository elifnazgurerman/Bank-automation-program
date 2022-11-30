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
    public partial class CustomerCreateDeleteWalletForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int walletId = 0;
        int currencyId = 0;
        bool didAddCurrencyNameRow = false;

        public CustomerCreateDeleteWalletForm()
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

        private void CreateDeleteForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void walletListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tempWalletId = walletListDataGridView.CurrentRow.Cells[0].Value.ToString();
            walletId = int.Parse(tempWalletId);

            string tempCurrencyId = walletListDataGridView.CurrentRow.Cells[2].Value.ToString();
            currencyId = int.Parse(tempCurrencyId);

            var tempCurrency =
                from currency in bank.CurrencyLists
                where currency.currency_id == currencyId
                select currency;

            currencyNameTextBox.Text = tempCurrency.First().currency_name;
            currencyShortNameTextBox.Text = tempCurrency.First().currency_shortname;
            exchangeRateTextBox.Text = tempCurrency.First().exchange_rate.ToString();
            amountTextBox.Text = walletListDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void addWalletButton_Click(object sender, EventArgs e)
        {
            var newWalletCurrency =
                from currency in bank.CurrencyLists
                where currency.currency_shortname == currencyShortNameTextBox.Text
                select currency;
            if (newWalletCurrency != null && newWalletCurrency.Count() > 0)
            {
                SQL.WalletList newWallet = new SQL.WalletList();
                newWallet.user_id = Supporting_Files.Variables.userID;
                newWallet.currency_id = newWalletCurrency.First().currency_id;
                newWallet.wallet_weight = 0;
                bank.WalletLists.InsertOnSubmit(newWallet);
                bank.SubmitChanges();
                var lastWallet = bank.WalletLists.OrderByDescending(x => x.wallet_id).FirstOrDefault(x => x.user_id == Supporting_Files.Variables.userID);
                SQL.ProcessList newProcess = new SQL.ProcessList();
                newProcess.process_type = 4;
                newProcess.sending_wallet = lastWallet.wallet_id;
                newProcess.amount = 0;
                newProcess.process_owner = Supporting_Files.Variables.userID;
                newProcess.is_approved = false;
                newProcess.process_date = Supporting_Files.Variables.currentDate;
                bank.ProcessLists.InsertOnSubmit(newProcess);
                bank.SubmitChanges();
                UpdateDataGridView();
            }

            else
            {
                MessageBox.Show("Currency not recognized.");
            }
        }

        private void deleteCurrencyButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(amountTextBox.Text) == 0)
            {
                SQL.ProcessList newProcess = new SQL.ProcessList();
                newProcess.process_type = 5;
                newProcess.sending_wallet = walletId;
                newProcess.amount = 0;
                newProcess.process_owner = Supporting_Files.Variables.userID;
                newProcess.is_approved = false;
                newProcess.process_date = Supporting_Files.Variables.currentDate;
                bank.ProcessLists.InsertOnSubmit(newProcess);
                bank.SubmitChanges();
                UpdateDataGridView();
            }

            else
            {
                MessageBox.Show("Wallet cannot be deleted.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new CustomerMainForm();
            form.Show();
        }
    }
}
