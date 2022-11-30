using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Manager
{
    public partial class ManagerEditCurrenciesForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int currencyId = 0;

        public ManagerEditCurrenciesForm()
        {
            InitializeComponent();
        }

        private void UpdateDataGridView()
        {
            var query = 
                from currency in bank.CurrencyLists
                select currency;

            currencyListDataGridView.DataSource = query;
            currencyListDataGridView.Columns[0].Visible = false;
            currencyListDataGridView.Columns[1].HeaderText = "Currency Name";
            currencyListDataGridView.Columns[2].HeaderText = "Currency's Short Name";
            currencyListDataGridView.Columns[3].HeaderText = "Exchange Rate";
        }

        private void EditCurrenciesForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void updateCurrencyButton_Click(object sender, EventArgs e)
        {
            var updateQuery = 
                from currency in bank.CurrencyLists
                where currency.currency_id == currencyId
                select currency;

            foreach (var currency in updateQuery)
            {
                currency.currency_name = currencyNameTextBox.Text;
                currency.currency_shortname = currencyShortNameTextBox.Text;
                currency.exchange_rate = float.Parse(exchangeRateTextBox.Text);
            }

            bank.SubmitChanges();
            UpdateDataGridView();
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            SQL.CurrencyList newCurrency = new SQL.CurrencyList();
            newCurrency.currency_name = currencyNameTextBox.Text;
            newCurrency.currency_shortname = currencyShortNameTextBox.Text;
            newCurrency.exchange_rate = float.Parse(exchangeRateTextBox.Text);
            bank.CurrencyLists.InsertOnSubmit(newCurrency);
            bank.SubmitChanges();
            UpdateDataGridView();
        }

        private void currencyListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = currencyListDataGridView.CurrentRow.Cells[0].Value.ToString();
            currencyId = int.Parse(temp);
            currencyNameTextBox.Text = currencyListDataGridView.CurrentRow.Cells[1].Value.ToString();
            currencyShortNameTextBox.Text = currencyListDataGridView.CurrentRow.Cells[2].Value.ToString();
            exchangeRateTextBox.Text = currencyListDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new ManagerMainForm();
            form.Show();
        }

        private void deleteCurrencyButton_Click(object sender, EventArgs e)
        {
            var deleteQuery =
                from currency in bank.CurrencyLists
                where currency.currency_id == currencyId
                select currency;

            foreach (var currency in deleteQuery)
            {
                bank.CurrencyLists.DeleteOnSubmit(currency);
            }

            bank.SubmitChanges();
            UpdateDataGridView();
        }
    }
}
