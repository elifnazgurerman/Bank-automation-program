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
    public partial class CustomerShowFinancialStatusForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public CustomerShowFinancialStatusForm()
        {
            InitializeComponent();
        }

        private void CustomerShowFinancialStatusForm_Load(object sender, EventArgs e)
        {
            var processList =
                from process in bank.ProcessLists
                where process.process_owner == Supporting_Files.Variables.userID
                select process;

            FinancialStatusDataGridView.DataSource = processList;

            FinancialStatusDataGridView.Columns[1].Visible = false;
            FinancialStatusDataGridView.Columns[6].Visible = false;
            FinancialStatusDataGridView.Columns[7].Visible = false;
            FinancialStatusDataGridView.Columns[9].Visible = false;
            FinancialStatusDataGridView.Columns[10].Visible = false;
            FinancialStatusDataGridView.Columns[11].Visible = false;
            FinancialStatusDataGridView.Columns[12].Visible = false;
            FinancialStatusDataGridView.Columns[0].HeaderText = "Process ID";
            FinancialStatusDataGridView.Columns[2].HeaderText = "Sender";
            FinancialStatusDataGridView.Columns[3].HeaderText = "Target";
            FinancialStatusDataGridView.Columns[4].HeaderText = "Amount";
            FinancialStatusDataGridView.Columns[5].HeaderText = "Aproved";
            FinancialStatusDataGridView.Columns[8].HeaderText = "Date";

            FinancialStatusDataGridView.Columns.Add("process_name", "Process Name");

            int rowCount = 0;

            foreach (var process in processList)
            {
                var nameForProcess =
                    from processType in bank.ProcessTypeLists
                    where processType.process_type == process.process_type
                    select processType.process_name;

                FinancialStatusDataGridView.Rows[rowCount].Cells["process_name"].Value = nameForProcess.FirstOrDefault();
                rowCount++;
            }
        }
    }
}
