using Buisness_Application.BL;
using Buisness_Application.DL;
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
    public partial class RemoveRevenueForm : Form
    {
        public RemoveRevenueForm()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void DeleteData()
        {
            string title = cbExpense.Text;
            if (title == null)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                foreach (FinancialRecord i in Finance.GetFinancialRecordList())
                {
                    if (i is Revenue)
                    {
                        Revenue expenseRecord = (Revenue)i;
                        if (i.GetBillName() == title)
                        {
                            FinancialRecordDL.RemoveFromList(title);
                            FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());
                            lblErrorLine.Visible = true;
                            break;
                        }

                    }
                }
            }
        }


        private void AddData()
        {
            foreach (FinancialRecord i in Finance.GetFinancialRecordList())
            {
                if (i is Revenue)
                {
                    cbExpense.Items.Add(i.GetBillName());

                }
            }
        }

        private void RemoveRevenueForm_Load(object sender, EventArgs e)
        {
            AddData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FinanceForm();
            f.Show();
        }
    }
}
