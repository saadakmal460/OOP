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
    public partial class RemoveHosteliteForm : Form
    {
        public RemoveHosteliteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RemoveHosteliteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = CheckName();
            if(flag)
            {
                ShowContents();
            }
            else
            {
                lblNotFound.Visible = true;
            }
        }


        private void ShowContents()
        {
            lblMessage.Visible = true;
            checkBoxYes.Visible = true;
            checkBoxNo.Visible = true;
            btnFind.Visible = false;
            lblNotFound.Visible = true;
            btnDelete.Visible = true;
            lblNotFound.Text = "Recored Found!!";
            lblNotFound.ForeColor = Color.Green;
        }
        private bool CheckName()
        {
            string name = txtUsename.Text;
            bool flag = false;
            foreach (User user in UserDL.GetSortedList())
            {
                if (user is Hostelite)
                {
                    Hostelite hostelite = (Hostelite)user;
                    if (name == hostelite.GetUsername())
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtUsename.Text;

            if (checkBoxYes.Checked)
            {
                lblDeleted.Visible = true;
                UserDL.RemoveUserFromList(name);
                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }
    }
}
