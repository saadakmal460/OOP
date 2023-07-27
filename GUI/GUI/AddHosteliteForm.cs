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
    public partial class AddHosteliteForm : Form
    {
        public AddHosteliteForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            string name = txtUsename.Text;
            bool flag = Validations.ValidateName(name);
            if(!flag)
            {
                lblerrorName.Visible = true;
                
            }
            else
            {
                lblerrorName.Visible = false;
            }

            string rollNumber = txtRollNumber.Text;
            bool flag2 = Validations.ValidateRollNumber(rollNumber);
            if (!flag2)
            {
                lblErrorRollNumber.Visible = true;

            }
            else
            {
                lblErrorRollNumber.Visible = false;
            }

            string cnic = txtCnic.Text;
            bool flag3 = Validations.ValidateCNIC(cnic);
            if (!flag3)
            {
                lblErrorCnic.Visible = true;

            }
            else
            {
                lblErrorCnic.Visible = false;
            }

            string city = txtCity.Text;
            bool flag4 = Validations.ValidateCity(city);
            if (!flag4)
            {
                lblErrorCity.Visible = true;

            }
            else
            {
                lblErrorCity.Visible = false;
            }

            string roomNumber = txtRoomNumber.Text;
            bool flag5 = Validations.ValidateRoomNumber(roomNumber);
           
            if (!flag5)
            {
                lblErrorRoom.Visible = true;

            }
            else
            {
                lblErrorRoom.Visible = false;
            }

            string password = txtPassword.Text;
            bool flag6 = Validations.ValidatePassword(password);
            if (!flag6)
            {
                lblErrorPassword.Visible = true;

            }
            else
            {
                lblErrorPassword.Visible = false;
            }

            if (flag && flag2 && flag3 && flag4 && flag5 && flag6)
            {
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Data saved Sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                Hostelite h = new Hostelite(name, cnic, city, rollNumber, password, "hostelite", roomNumber);
                Admin.AdddInList(h);
                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                
            }
            else
            {
                lblErrorLine.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new AdminForm();
            f.Show();
            this.Close();
        }

        private void Clear()
        {
            txtUsename.Text = "";
            txtRollNumber.Text = "";
            txtCnic.Text = "";
            txtCity.Text = "";
            txtRoomNumber.Text = "";
            txtPassword.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void AddHosteliteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
