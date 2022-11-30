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
    public partial class ManagerSetCreditInterestRatesForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public ManagerSetCreditInterestRatesForm()
        {
            InitializeComponent();

            var initialQuery =
                from interestRate in bank.InterestRates
                where interestRate.id == 1
                select interestRate;

            SQL.InterestRate temp = initialQuery.First();
            interestRateTextBox.Text = temp.default_interest_rate.ToString();
            delayedInterestRateTextBox.Text = temp.delayed_interest_rate.ToString();
        }

        private void updateInterestRateButton_Click(object sender, EventArgs e)
        {
            var updateQuery =
                from interestRate in bank.InterestRates
                where interestRate.id == 1
                select interestRate;

            foreach (var interestRate in updateQuery)
            {
                interestRate.default_interest_rate = Convert.ToDecimal(interestRateTextBox.Text);
                interestRate.delayed_interest_rate = Convert.ToDecimal(delayedInterestRateTextBox.Text);
            }

            bank.SubmitChanges();
        }
    }
}
