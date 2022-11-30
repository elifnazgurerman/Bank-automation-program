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
    public partial class ManagerEmployeeSalariesForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public ManagerEmployeeSalariesForm()
        {
            InitializeComponent();
        }

        private void SetSalariesButton_Click(object sender, EventArgs e)
        {
            if (SalariesTextBox.Text.Length > 0)
            {
                var salariesList =
                    from salary in bank.SalariesLists
                    select salary;

                foreach (var salary in salariesList)
                {
                    salary.salary = Convert.ToDecimal(SalariesTextBox.Text);
                }

                bank.SubmitChanges();
            }
        }

        private void EmployeeSalariesForm_Load(object sender, EventArgs e)
        {
            var salariesList =
                from salary in bank.SalariesLists
                select salary;

            SalariesTextBox.Text = salariesList.FirstOrDefault().salary.ToString();
        }
    }
}
