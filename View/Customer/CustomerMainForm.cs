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
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        private void UpdateContactInfoButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Customer.CustomerUpdateContactInfoForm();
            form.Show();
        }

        private void CreateDeleteWalletButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Customer.CustomerCreateDeleteWalletForm();
            form.Show();
        }

        private void DepositWithdrawMoneyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Customer.CustomerDepositWithdrawMoneyForm();
            form.Show();
        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Customer.CustomerTransferMoneyForm();
            form.Show();
        }

        private void logutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Supporting_Files.Variables.userID = -1;
            Supporting_Files.Variables.representerID = -1;
            Form form = new LoginForm();
            form.Show();
        }

        private void ShowFinancialStatusButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Customer.CustomerShowFinancialStatusForm();
            form.Show();
        }

        private void requestLoanButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Customer.CustomerLoanListForm();
            form.Show();
        }
    }
}
