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
    public partial class CustomerUpdateContactInfoForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerUpdateContactInfoForm()
        {
            InitializeComponent();

            var initialQuery =
                from contactInfo in bank.ContactInfoLists
                where contactInfo.user_id == Supporting_Files.Variables.userID
                select contactInfo;

            SQL.ContactInfoList temp = initialQuery.First();
            addressTextBox.Text = temp.adress;
            phoneTextBox.Text = temp.phone;
        }

        private void updateContactInfoButton_Click(object sender, EventArgs e)
        {
            var updateQuery =
                from contactInfo in bank.ContactInfoLists
                where contactInfo.user_id == Supporting_Files.Variables.userID
                select contactInfo;

            foreach (var contactInfo in updateQuery)
            {
                contactInfo.adress = addressTextBox.Text;
                contactInfo.phone = phoneTextBox.Text;
            }

            bank.SubmitChanges();
        }
    }
}
