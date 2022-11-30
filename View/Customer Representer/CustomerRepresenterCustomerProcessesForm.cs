using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLM210_ProgramlamaLaboratuvari2_Proje3.View.Customer_Representer
{
    public partial class CustomerRepresenterCustomerProcessesForm : Form
    {
        int selectedProcessID = 0;

        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerRepresenterCustomerProcessesForm()
        {
            InitializeComponent();
        }

        private void CustomerRepresenterCustomerProcessesForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            var walletInitialQuery = 
                from wallet in bank.WalletLists
                where wallet.user_id == Supporting_Files.Variables.userID
                select wallet;

            WalletListDataGridView.DataSource = walletInitialQuery;

            WalletListDataGridView.Columns[0].HeaderText = "Wallet ID";
            WalletListDataGridView.Columns[1].HeaderText = "Owner ID";
            WalletListDataGridView.Columns[2].HeaderText = "Currency ID";
            WalletListDataGridView.Columns[3].HeaderText = "Balance";
            WalletListDataGridView.Columns[5].HeaderText = "Active";
            WalletListDataGridView.Columns[5].HeaderText = "Approved";

            WalletListDataGridView.Columns[4].Visible = false;
            WalletListDataGridView.Columns[6].Visible = false;
            WalletListDataGridView.Columns[7].Visible = false;

            var processInitialQuery =
                from process in bank.ProcessLists
                where process.process_owner == Supporting_Files.Variables.userID
                select process;

            ProcessListDataGridView.DataSource = processInitialQuery;

            ProcessListDataGridView.Columns[0].HeaderText = "Process ID";
            ProcessListDataGridView.Columns[1].HeaderText = "Process Type";
            ProcessListDataGridView.Columns[2].HeaderText = "Sender";
            ProcessListDataGridView.Columns[3].HeaderText = "Target";
            ProcessListDataGridView.Columns[4].HeaderText = "Balance";
            ProcessListDataGridView.Columns[5].HeaderText = "Approved";
            ProcessListDataGridView.Columns[7].HeaderText = "Owner ID";

            ProcessListDataGridView.Columns[6].Visible = false;
            ProcessListDataGridView.Columns[8].Visible = false;
            ProcessListDataGridView.Columns[9].Visible = false;
            ProcessListDataGridView.Columns[10].Visible = false;
            ProcessListDataGridView.Columns[11].Visible = false;
            ProcessListDataGridView.Columns[12].Visible = false;
        }

        private void ProcessListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProcessID = Convert.ToInt32(ProcessListDataGridView.CurrentRow.Cells[0].Value);
            SelectedProcessTextBox.Text = selectedProcessID.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new CustomerRepresenterMainForm();
            form.Show();
        }

        private void ApproveProcessButton_Click(object sender, EventArgs e)
        {
            if (selectedProcessID != 0)
            {
                var updateQuery = 
                    from process in bank.ProcessLists
                    where process.process_id == selectedProcessID
                    select process;

                foreach(var process in updateQuery)
                {
                    process.is_approved = true;
                }

                bank.SubmitChanges();
            }

            else
            {
                MessageBox.Show("Please select a process from the list.");
            }
        }
    }
}
