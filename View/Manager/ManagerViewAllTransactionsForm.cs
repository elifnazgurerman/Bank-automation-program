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
    public partial class ManagerViewAllTransactionsForm : Form
    {
        SQL.BankDBDataContext bank = new SQL.BankDBDataContext(Properties.Settings.Default.BankDBConnectionString);

        public ManagerViewAllTransactionsForm()
        {
            InitializeComponent();
        }

        private void ManagerViewAllTransactionsForm_Load(object sender, EventArgs e)
        {
            this.processListTableAdapter.Fill(this.bankDBDataSet.ProcessList);
            int rowCount = 0;

            var processList =
                from process in bank.ProcessLists
                select process;

            foreach (var process in processList)
            {
                var nameForProcess =
                    from processType in bank.ProcessTypeLists
                    where processType.process_type == process.process_type
                    select processType.process_name;

                processListDataGridView.Rows[rowCount].Cells["process_name"].Value = nameForProcess.FirstOrDefault();

                var targetBalance =
                    from wallet in bank.WalletLists
                    where wallet.wallet_id == process.target_wallet
                    select wallet.wallet_weight;

                processListDataGridView.Rows[rowCount].Cells["target_wallet_weight"].Value = targetBalance.FirstOrDefault();

                var senderBalance =
                    from wallet in bank.WalletLists
                    where wallet.wallet_id == process.sending_wallet
                    select wallet.wallet_weight;

                processListDataGridView.Rows[rowCount].Cells["sending_wallet_weight"].Value = senderBalance.FirstOrDefault();
                rowCount += 1;
            }
        }
    }
}
