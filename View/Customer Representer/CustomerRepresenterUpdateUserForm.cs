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
    public partial class CustomerRepresenterUpdateUserForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerRepresenterUpdateUserForm()
        {
            InitializeComponent();
        }

        private void CustomerRepresenterUpdateUserForm_Load(object sender, EventArgs e)
        {
            var userList =
                from user in bank.UserLists
                where user.user_id == Supporting_Files.Variables.userID
                select user;

            var contactInfoList =
                from info in bank.ContactInfoLists
                where info.user_id == Supporting_Files.Variables.userID
                select info;

            UsernameTextBox.Text = userList.FirstOrDefault().username;
            PasswordTextBox.Text = userList.FirstOrDefault().password;
            AddressTextBox.Text = contactInfoList.FirstOrDefault().adress;
            PhoneNumberTextBox.Text = contactInfoList.FirstOrDefault().phone;
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            var userUpdateQuery =
                from user in bank.UserLists
                where user.user_id == Supporting_Files.Variables.userID
                select user;

            foreach (var user in userUpdateQuery)
            {
                user.username = UsernameTextBox.Text;
                user.password = PasswordTextBox.Text;
            }

            var contactInfoUpdateQuery =
                from info in bank.ContactInfoLists
                where info.user_id == Supporting_Files.Variables.userID
                select info;

            foreach (var contactInfo in contactInfoUpdateQuery)
            {
                contactInfo.adress = AddressTextBox.Text;
                contactInfo.phone = PhoneNumberTextBox.Text;
            }

            try
            {
                bank.SubmitChanges();
                MessageBox.Show("User info updated successfully.");
            }

            catch
            {
                MessageBox.Show("Error updating user info.");
            }
        }
    }
}
