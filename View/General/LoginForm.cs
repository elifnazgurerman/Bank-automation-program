using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BLM210_ProgramlamaLaboratuvari2_Proje3
{
    public partial class LoginForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != null && usernameTextBox.Text.Length > 0)
            {
                if (passwordTextBox.Text != null && passwordTextBox.Text.Length > 0)
                {
                    var userId =
                        from user in bank.UserLists
                        where user.username == usernameTextBox.Text
                        select user.user_id;

                    if (userId.Count() > 0)
                    {
                        var password =
                            from user in bank.UserLists
                            where user.user_id == userId.FirstOrDefault()
                            select user.password;

                        if (password.Count() > 0)
                        {
                            if (password.FirstOrDefault() == passwordTextBox.Text)
                            {
                                var userType =
                                    from user in bank.UserLists
                                    where user.user_id == userId.FirstOrDefault()
                                    select user.user_type;

                                var dateList = 
                                    from date in bank.Dates
                                    select date;

                                Supporting_Files.Variables.currentDate = Convert.ToDateTime(dateList.OrderByDescending(date => date.id).FirstOrDefault().currentDate.ToString());

                                switch (userType.First())
                                {
                                    case 2:
                                        this.Hide();
                                        ManagerMainForm managerMainForm = new ManagerMainForm();
                                        managerMainForm.Show();
                                        return;
                                    case 3:
                                        Supporting_Files.Variables.representerID = userId.FirstOrDefault();
                                        this.Hide();
                                        CustomerRepresenterMainForm customerRepresenterMainForm = new CustomerRepresenterMainForm();
                                        customerRepresenterMainForm.Show();
                                        return;
                                    case 4:
                                        Supporting_Files.Variables.userID = userId.FirstOrDefault();
                                        this.Hide();
                                        CustomerMainForm customerMainForm = new CustomerMainForm();
                                        customerMainForm.Show();
                                        return;
                                    default:
                                        MessageBox.Show("UserType out of range. UserType: " + userType.FirstOrDefault());
                                        break;
                                }
                            }

                            else
                            {
                                MessageBox.Show("Username or password is wrong.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Username or password is wrong.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Username or password is wrong.");
                    }

                }

                else
                {
                    MessageBox.Show("Password is empty.");
                }
            }

            else
            {
                MessageBox.Show("Username is empty.");
            }
        }
    }
}
