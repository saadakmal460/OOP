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
    public partial class PayFeeForm : Form
    {
        public PayFeeForm()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PayFee();
        }

        private void PayFee()
        {
            bool flag = true;


            string bank = txtBak.Text;
            bool flag3 = Validations.ValidateName(bank);
            if (!flag3)
            {
                lblBank.Visible = true;
            }
            else
            {
                lblBank.Visible = false;

            }

            string acc = txtAcc.Text;
            bool flag4 = Validations.ValidateAccountNumber(acc);
            if (!flag4)
            {
                lblAcc.Visible = true;
            }
            else
            {
                lblAcc.Visible = false;

            }
            string challan = txtChallan.Text;
            string amount = txtAmount.Text;
            foreach (Challan i in Finance.GetChallanList())
            {
                if (i.GetChallanNumber() == challan && i.GetAmount() == amount)
                {
                    flag = true;
                    i.SetStatus("Paid");
                    break;
                }
                else
                {
                    flag = false;
                }

            }

            if (!flag || !flag3 || !flag4)
            {
                lblCheck.Visible = true;
            }
            else if (flag && flag3 && flag4)
            {
                lblCheck.Visible = true;
                lblCheck.Text = "Fee Pid Sucessfully";
                lblCheck.ForeColor = Color.Green;
                lblCheck.Visible = true;
                PayFee f = new PayFee(bank, acc, challan, amount);
                ChallanDL.StoreChallansInFile(ExtraBL.GetChallanPath());
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new HosteliteForm();
            f.Show();
        }
    }
}
