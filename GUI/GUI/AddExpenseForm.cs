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
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtExpense.Text;
            bool flag = Validations.ValidateCity(name);
            lblerrorName.Visible = !flag;

            string amount = txtAmount.Text;
            bool flag2 = Validations.ValidateNumber(amount);
            lblErrorAmount.Visible = !flag2;

            string tax = txtTax.Text;
            bool flag3 = Validations.ValidateNumber(tax);
            lblErrorTax.Visible = !flag3;

            if(flag && flag2 && flag3)
            {
                lblErrorLine.Text = "Data saved sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                lblErrorLine.Visible = true;
                Expense expense = new Expense(name, amount, tax, "Expense");
                Finance.AddInList(expense);
                FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());

            }
            else
            {
                lblErrorLine.Text = "Data was not saved! Check you inputs";
                lblErrorLine.ForeColor = Color.Crimson;
                lblErrorLine.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FinanceForm();
            f.Show();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtExpense_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblerrorName_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorTax_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpense.Text = "";
            txtAmount.Text = "";
            txtTax.Text = "";
        }
    }
}
