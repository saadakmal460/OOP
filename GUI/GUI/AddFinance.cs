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
    public partial class AddFinance : Form
    {
        public AddFinance()
        {
            InitializeComponent();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtUsename.Text;
            bool flag = Validations.ValidateName(name);
            if (!flag)
            {
                lblerrorName.Visible = true;

            }
            else
            {
                lblerrorName.Visible = false;
            }

            string employeeNo = txtEmployeeNo.Text;
            bool flag2 = Validations.ValidateEmployeeNumber(employeeNo);
            lblErrorEmployeeNo.Visible = !flag2;




            string password = txtPassword.Text;
            bool flag3 = Validations.ValidatePassword(password);
            if (!flag3)
            {
                lblErrorPassword.Visible = true;

            }
            else
            {
                lblErrorPassword.Visible = false;
            }

            if (flag && flag2 && flag3)
            {
                Finance f = new Finance(name, password, "Finance", employeeNo);
                UserDL.AdddInList(f);
                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());

                lblErrorLine.Text = "Data saved Sucessfully";
                lblErrorLine.Visible = true;
                lblErrorLine.ForeColor = Color.Green;
            }
            else
            {
                lblErrorLine.Visible = true;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtUsename.Text = "";
            txtEmployeeNo.Text = "";
            txtPassword.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AddOfficalForm();
            f.Show();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddFinance_Load(object sender, EventArgs e)
        {

        }
    }
}
