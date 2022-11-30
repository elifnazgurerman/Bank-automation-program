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
    public partial class ManagerAddCustomerForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        int lastRepresenterID = 0;
        int lastRepresentersCustomerCount = 999;

        public ManagerAddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0)
            {
                SQL.UserList newUser = new SQL.UserList();
                newUser.username = UsernameTextBox.Text;
                newUser.password = PasswordTextBox.Text;
                newUser.user_type = 4;
                bank.UserLists.InsertOnSubmit(newUser);

                try
                {
                    bank.SubmitChanges();
                } 

                catch
                {
                    MessageBox.Show("Error adding customer to database.");
                }
                

                var lastUser = bank.UserLists.OrderByDescending(user => user.user_id).FirstOrDefault();

                SQL.ContactInfoList newUserContactInfo = new SQL.ContactInfoList();
                newUserContactInfo.user_id = lastUser.user_id;
                newUserContactInfo.adress = AddressTextBox.Text;
                newUserContactInfo.phone = PhoneNumberTextBox.Text;
                bank.ContactInfoLists.InsertOnSubmit(newUserContactInfo);

                try
                {
                    bank.SubmitChanges();
                }

                catch
                {
                    MessageBox.Show("Error adding customer contact info to database.");
                }

                var representerList = 
                    from representer in bank.UserLists
                    where representer.user_type == 3
                    select representer;

                foreach (var representer in representerList)
                {
                    var representersCustomers =
                        from customer in bank.CustomerSharingLists
                        where customer.representer_id == representer.user_id
                        select customer;

                    if (representersCustomers.Count() <= lastRepresentersCustomerCount)
                    {
                        lastRepresentersCustomerCount = representersCustomers.Count();
                        lastRepresenterID = representer.user_id;
                    }
                }

                SQL.CustomerSharingList customerSharingList = new SQL.CustomerSharingList();
                customerSharingList.representer_id = lastRepresenterID;
                customerSharingList.customer_id = lastUser.user_id;
                bank.CustomerSharingLists.InsertOnSubmit(customerSharingList);

                try
                {
                    bank.SubmitChanges();
                }

                catch
                {
                    MessageBox.Show("Error adding customer sharing list to database.");
                }

                MessageBox.Show("Customer added successfully.");
            }

            else
            {
                MessageBox.Show("Username or password is empty.");
            }
        }
    }
}
