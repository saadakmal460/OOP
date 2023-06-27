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
    public partial class UpdateRecordForm : Form
    {
        public UpdateRecordForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = CheckName();
            if(flag)
            {
                ShowComponents();
            }
            else
            {
                lblNotFound.Visible = true;
            }
        }


        private void UpdatingRecord()
        {
            string name = txtUsename.Text;
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

            if (flag2 && flag3 && flag4 && flag5 && flag6)
            {
                updateInList(name , rollNumber , cnic , city , password , roomNumber);
                UserDL.StoreUsersInFile(ExtraBL.GetUsersPath());
                lblErrorLine.Text = "Record updated Sucessfully";
                lblErrorLine.ForeColor = Color.Green;
            }
            else
            {
                lblErrorLine.Visible = true;
            }
        }

        private void updateInList(string name, string rollNumber, string cnic, string city, string password , string roomNumber)
        {
            foreach (User i in UserDL.GetUserList())
            {
                if (i is Hostelite)
                {
                    if (i.GetUsername() == name)
                    {
                        Hostelite h = (Hostelite)i;

                        h.SetRollNumber(rollNumber);
                        h.SetCnic(cnic);
                        h.SetCity(city);
                        h.SetPassword(password);
                        h.SetRollNumber(rollNumber);

                    }
                }
            }
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

        private void ShowComponents()
        {
            lblRollNumber.Visible = true;
            txtRollNumber.Visible = true;

            lblCnic.Visible = true;
            txtCnic.Visible = true;

            lblCity.Visible = true;
            txtCity.Visible = true;

            lblRoomNumber.Visible = true;
            txtRoomNumber.Visible = true;

            lblPassword.Visible = true;
            txtPassword.Visible = true;

            btnConfirm.Visible = false;
            btnUpdate.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatingRecord();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new AdminForm();
            f.Show();
            this.Visible = false;
        }
    }
}
