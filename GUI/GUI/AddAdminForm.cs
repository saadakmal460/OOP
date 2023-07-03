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
    public partial class AddAdminForm : Form
    {
        public AddAdminForm()
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

            string contact = txtContact.Text;
            bool flag2 = Validations.ValidateContactNumber(contact);
            lblErrorContact.Visible = !flag2;

            
            

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
                Admin a = new Admin(name, password, contact, "admin");
                UserDL.AdddInList(a);
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

        

        private void txtUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AddOfficalForm();
            f.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtUsename.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
