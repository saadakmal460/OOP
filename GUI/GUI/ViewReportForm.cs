using Buisness_Application.BL;
using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI
{
    public partial class ViewReportForm : Form
    {
        public ViewReportForm()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowExpense()
        {
            int count = 0;
            int total = 0;

            // Clear any existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Retrieve the list of financial records
            List<FinancialRecord> financialRecordList = Finance.GetFinancialRecordList();

            // Create the columns in the DataGridView
            dataGridView1.Columns.Add("Expense", "Expense");
            dataGridView1.Columns.Add("Amount", "Amount");
            dataGridView1.Columns.Add("Tax", "Tax");

            // Set the desired column widths
            dataGridView1.Columns["Expense"].Width = 200;
            dataGridView1.Columns["Amount"].Width = 200;
            dataGridView1.Columns["Tax"].Width = 200;

            foreach (FinancialRecord record in financialRecordList)
            {
                if (record is Expense)
                {
                    Expense expenseRecord = (Expense)record;
                    count++;

                    // Create a new row in the DataGridView
                    DataGridViewRow row = new DataGridViewRow();

                    // Create cells for each column in the row
                    DataGridViewCell expenseCell = new DataGridViewTextBoxCell();
                    expenseCell.Value = count + "." + record.GetBillName();
                    row.Cells.Add(expenseCell);

                    DataGridViewCell amountCell = new DataGridViewTextBoxCell();
                    amountCell.Value = record.GetAmount().ToString();
                    row.Cells.Add(amountCell);

                    DataGridViewCell taxCell = new DataGridViewTextBoxCell();
                    taxCell.Value = expenseRecord.GetTax().ToString();
                    row.Cells.Add(taxCell);

                    // Add the row to the DataGridView
                    dataGridView1.Rows.Add(row);
                }
            }

            total = FinancialRecordDL.CalculateTotalAmount("Expense");
            DataGridViewRow footerRow = new DataGridViewRow();

            DataGridViewCell totalCell = new DataGridViewTextBoxCell();
            totalCell.Value = "Total";
            footerRow.Cells.Add(totalCell);

            footerRow.DefaultCellStyle.BackColor = Color.LightGray;
            footerRow.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", dataGridView1.Font.Size, FontStyle.Bold);

            DataGridViewCell totalExpenseCell = new DataGridViewTextBoxCell();
            totalExpenseCell.Value = total.ToString();
            footerRow.Cells.Add(totalExpenseCell);
            dataGridView1.Rows.Add(footerRow);

            dataGridView1.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new FinancialRecordForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new RevenueForm();
            f.Show();
            this.Close();
        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            ShowExpense();
        }
    }
}
