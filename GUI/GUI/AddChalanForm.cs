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
    public partial class AddChalanForm : Form
    {
        public AddChalanForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AddChalan();
        }

        private void AddChalan()
        {
            bool flag = true;
            string rollNumber = comboBoxRollNumber.Text;
            if(rollNumber == null)
            {
                flag = false;
            }

            string challan = txtChallan.Text;
            bool flag2 = Validations.ValidateChallan(challan);
            lblChallanNumber.Visible = !flag2;

            bool flag3 = ChallanDL.CheckInChallanList(rollNumber);
            
            string amount = txtAmount.Text;
            bool flag4 = Validations.ValidateNumber(amount);
            lblAmount.Visible = !flag4;

            if(!flag3 && flag2 && flag4 && flag)
            {
                Challan c = new Challan(rollNumber, challan, amount, "Pending");
                Finance.AddChallanInList(c);
                ChallanDL.StoreChallansInFile(ExtraBL.GetChallanPath());
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Challan generated sucessfully";
                lblErrorLine.ForeColor = Color.Green;
            }
            else if(flag3 && flag2 && flag4 && flag)
            {
                foreach (Challan i in Finance.GetChallanList())
                {
                    if (rollNumber == i.GetRollNumber())
                    {
                        i.SetChallanNumber(challan);
                        i.SetAmount(amount);
                        i.SetStatus("Pending");
                        break;
                    }
                }
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Challan updated sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                ChallanDL.StoreChallansInFile(ExtraBL.GetChallanPath());

            }
            else
            {
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Data not saved!! Check inputs";
                lblErrorLine.ForeColor = Color.Crimson;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new FinanceForm();
            f.Show();
        }

        private void AddChalanForm_Load(object sender, EventArgs e)
        {
            foreach (User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite hostelite = (Hostelite)i;
                    comboBoxRollNumber.Items.Add(hostelite.GetRollNumber());
                }
            }
        }
    }
}
