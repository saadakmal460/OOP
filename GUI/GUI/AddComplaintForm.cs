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
    public partial class AddComplaintForm : Form
    {
        public AddComplaintForm()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorLine_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string complaint = txtComplaint.Text;
            bool flag = Validations.ValidateNotice(complaint);
            if(flag)
            {
                Complaints c = new Complaints(ExtraBL.GetName(), complaint);
                Hostelite.AddComplaintsInList(c);
                ComplaintsDL.StoreComplaintsInFile(ExtraBL.GetComplaintsPath());
                MessageBox.Show(Hostelite.GetComplaintsList().Count.ToString());
                lblComplaint.Visible = false;
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Complaint added sucessfully";
                lblErrorLine.ForeColor = Color.Green;
            }
            else
            {
                lblComplaint.Visible = true;
                lblErrorLine.Visible = true;
                lblErrorLine.Text = "Data not saved check inputs";
                lblErrorLine.ForeColor = Color.Crimson;

            }
        }

        private void lblNotice_Click(object sender, EventArgs e)
        {

        }

        private void txtNotice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblerrorName_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComplaint.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new HosteliteForm();
            f.Show();
        }
    }
}
