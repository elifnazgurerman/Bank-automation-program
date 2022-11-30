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
    public partial class ManagerFinancialStatusForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        decimal income = 0;
        decimal outcome = 0;
        decimal profit = 0;
        decimal totalBalance = 0;

        public ManagerFinancialStatusForm()
        {
            InitializeComponent();
        }

        private void ManagerFinancialStatusForm_Load(object sender, EventArgs e)
        {
            var walletList =
                from wallet in bank.WalletLists
                where wallet.wallet_id == 29
                select wallet;

            totalBalance = walletList.FirstOrDefault().wallet_weight;
            TotalBalanceTextBox.Text = totalBalance.ToString();

            var sendingProcessList = 
                from process in bank.ProcessLists
                where process.sending_wallet == 29 && process.process_date == Supporting_Files.Variables.currentDate
                select process;

            foreach(var sendingProcess in sendingProcessList)
            {
                outcome += sendingProcess.amount;
            }

            var targetProcessList =
                from process in bank.ProcessLists
                where process.target_wallet == 29
                select process;

            foreach (var targetProcess in targetProcessList)
            {
                income += targetProcess.amount;
            }

            profit = income - outcome;

            IncomeTextBox.Text = income.ToString();
            OutcomeTextBox.Text = outcome.ToString();
            ProfitTextBox.Text = profit.ToString();
        }
    }
}
