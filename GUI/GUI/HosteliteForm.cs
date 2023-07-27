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
    public partial class HosteliteForm : Form
    {
        public HosteliteForm()
        {
            InitializeComponent();
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new PayFeeForm();
            f.Show();
        }

        private void HosteliteForm_Load(object sender, EventArgs e)
        {
            ShowInfo(ExtraBL.GetName());
        }

        private void ShowInfo(string name)
        {
            foreach(User i in Admin.GetUserList())
            {
                if (i is Hostelite)
                {
                    Hostelite hostelite = (Hostelite)i;
                    if (name == i.GetUsername())
                    {

                        lblUname.Text = hostelite.GetUsername();
                        lblUroll.Text = hostelite.GetRollNumber();
                        lblUCnic.Text = hostelite.GetCnic();
                        lblUcity.Text = hostelite.GetCity();
                        lblURoom.Text = hostelite.GetRoomNumber();


                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            Form f = new ViewNoticesForm();
            f.Show();
            this.Close();
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            Form f = new ViewMessForm();
            f.Show();
            this.Close();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            Form f = new AddReviewForm();
            f.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new LoginFrom();
            f.Show();
            this.Close();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            Form f = new AddComplaintForm();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new RemoveRegistrationForm();
            f.Show();
            this.Close();
        }
    }
}
