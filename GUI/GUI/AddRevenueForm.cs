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
    public partial class AddRevenueForm : Form
    {
        public AddRevenueForm()
        {
            InitializeComponent();
        }

        private void AddRevenueForm_Load(object sender, EventArgs e)
        {
            comboBoxOption.Items.Add("Yes");
            comboBoxOption.Items.Add("No");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtRevenue.Text;
            bool flag = Validations.ValidateCity(name);
            lblerrorName.Visible = !flag;

            string amount = txtAmount.Text;
            bool flag2 = Validations.ValidateNumber(amount);

            bool flag3 = true;
            string option = comboBoxOption.Text;
            if(option == null)
            {
                lblOption.Visible = true;
                flag3 = false;
            }
            else
            {
                lblOption.Visible = false;
            }


            if (flag && flag2 && flag3)
            {
                lblErrorLine.Text = "Data saved sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                lblErrorLine.Visible = true;
                Revenue revenue = new Revenue(name, amount, option, "Revenue");
                Finance.AddInList(revenue);
                FinancialRecordDL.StoreInFile(ExtraBL.GetRecordPath());

            }
            else
            {
                lblErrorLine.Text = "Data was not saved! Check you inputs";
                lblErrorLine.ForeColor = Color.Crimson;
                lblErrorLine.Visible = true;
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtRevenue.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FinanceForm();
            f.Show();
        }
    }
}
