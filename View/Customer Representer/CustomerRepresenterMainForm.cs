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
    public partial class CustomerRepresenterMainForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerRepresenterMainForm()
        {
            InitializeComponent();
        }

        private void UpdateDataGridView()
        {
            var customerList =
                from customer in bank.CustomerSharingLists
                where customer.representer_id == Supporting_Files.Variables.representerID
                select customer;

            int rowCount = 0;

            foreach (var customer in customerList)
            {
                var userList =
                    from user in bank.UserLists
                    where user.user_id == customer.customer_id
                    select user;

                customerListDataGridView.Rows.Add();

                customerListDataGridView.Rows[rowCount].Cells["user_id"].Value = userList.FirstOrDefault().user_id.ToString();
                customerListDataGridView.Rows[rowCount].Cells["username"].Value = userList.FirstOrDefault().username;
                customerListDataGridView.Rows[rowCount].Cells["password"].Value = userList.FirstOrDefault().password;
                rowCount ++;
            }
        }
        
        private void CustomerRepresenterMainForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void customerListDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Supporting_Files.Variables.userID = Convert.ToInt32(customerListDataGridView.CurrentRow.Cells[0].Value);
            SelectedCustomerTextBox.Text = Supporting_Files.Variables.userID.ToString();
        }

        private void CustomerProcessButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new View.Customer_Representer.CustomerRepresenterCustomerProcessesForm();
            form.Show();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Form form = new View.Manager.ManagerAddCustomerForm();
            form.Show();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            if (Supporting_Files.Variables.userID > 0)
            {
                Form form = new View.Customer_Representer.CustomerRepresenterUpdateUserForm();
                form.Show();
            }
            
            else
            {
                MessageBox.Show("Please select a user from the list.");
            }
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (Supporting_Files.Variables.userID > 0)
            {
                var infoDeleteQuery =
                    from info in bank.ContactInfoLists
                    where info.user_id == Supporting_Files.Variables.userID
                    select info;

                foreach (var info in infoDeleteQuery)
                {
                    bank.ContactInfoLists.DeleteOnSubmit(info);
                }

                var processDeleteQuery =
                    from process in bank.ProcessLists
                    where process.process_owner == Supporting_Files.Variables.userID
                    select process;

                foreach (var process in processDeleteQuery)
                {
                    bank.ProcessLists.DeleteOnSubmit(process);
                }

                var walletDeleteQuery =
                    from wallet in bank.WalletLists
                    where wallet.user_id == Supporting_Files.Variables.userID
                    select wallet;

                foreach (var wallet in walletDeleteQuery)
                {
                    bank.WalletLists.DeleteOnSubmit(wallet);
                }

                var userDeleteQuery =
                    from user in bank.UserLists
                    where user.user_id == Supporting_Files.Variables.userID
                    select user;

                foreach (var user in userDeleteQuery)
                {
                    bank.UserLists.DeleteOnSubmit(user);
                }

                var sharingDeleteQuery =
                    from user in bank.CustomerSharingLists
                    where user.customer_id == Supporting_Files.Variables.userID
                    select user;

                foreach (var user in sharingDeleteQuery)
                {
                    bank.CustomerSharingLists.DeleteOnSubmit(user);
                }

                try
                {
                    bank.SubmitChanges();
                }

                catch 
                {
                    MessageBox.Show("Error deleting user.");
                }
                UpdateDataGridView();
            }

            else
            {
                MessageBox.Show("Please select a user from the list.");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Supporting_Files.Variables.userID = -1;
            Supporting_Files.Variables.representerID = -1;
            Form form = new LoginForm();
            form.Show();
        }
    }
}
