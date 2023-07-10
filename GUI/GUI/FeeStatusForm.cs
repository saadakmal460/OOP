using Buisness_Application.BL;
using GUI.DL;
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
    public partial class FeeStatusForm : Form
    {
        public FeeStatusForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FeeStatusForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("RollNumber", "Roll Number");
            dataGridView1.Columns.Add("FeeStatus", "Fee Status");

            dataGridView1.Columns["RollNumber"].Width = 200;
            dataGridView1.Columns["FeeStatus"].Width = 200;

            

            foreach(Challan i in Finance.GetChallanList())
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell rollNumber = new DataGridViewTextBoxCell();
                rollNumber.Value = i.GetRollNumber();
                row.Cells.Add(rollNumber);

                DataGridViewCell status = new DataGridViewTextBoxCell();
                status.Value = i.GetStatus();
                row.Cells.Add(status);

                dataGridView1.Rows.Add(row);
            }
            dataGridView1.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FinanceForm();
            f.Show();
        }
    }
}
