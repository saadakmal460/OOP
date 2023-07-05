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
    public partial class RemoveRegistrationForm : Form
    {
        public RemoveRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            string name = txtUsename.Text;
            string password = txtPassword.Text;
            bool flag = false;
            foreach(User i in UserDL.GetUserList())
            {
                if(name == ExtraBL.GetName() && i.GetUsername() == ExtraBL.GetName() && password == i.GetPassword() && checkBox1.Checked)
                {
                    UserDL.RemoveUserFromList(ExtraBL.GetName());
                    flag = true;
                    break;
                    
                }
            }
            if(!flag)
            {
                lblerrorLine.Visible = true;
            }
            else
            {
                lblerrorLine.Text = "Your account has been removed";
                lblerrorLine.ForeColor = Color.Green;
                lblerrorLine.Visible = true;
                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                
                this.Close();
                Form f = new LoginFrom();
                f.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new HosteliteForm();
            f.Show();
        }
    }
}
