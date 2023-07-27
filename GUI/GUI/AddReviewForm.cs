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
    public partial class AddReviewForm : Form
    {
        public AddReviewForm()
        {
            InitializeComponent();
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            comboBoxRating.Items.Add("1");
            comboBoxRating.Items.Add("2");
            comboBoxRating.Items.Add("3");
            comboBoxRating.Items.Add("4");
            comboBoxRating.Items.Add("5");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string rating = comboBoxRating.Text;
            string review = txtReview.Text;
            bool flag = Validations.ValidateNotice(review);

            if(flag)
            {
                lblError.Text = "Review Added SucssFully";
                lblError.ForeColor = Color.Green;
                lblError.Visible = true;
                lblErrorLine.Visible = false;
                Reviews r = new Reviews(ExtraBL.GetName(), rating, review);
                Hostelite.AddInList(r);
                ReviewsDL.StoreReviewsInFile(ExtraBL.GetReviewsPath());
                
            }
            else
            {
                lblError.Text = "Check you inputs!!";
                lblError.ForeColor = Color.Crimson;
                lblError.Visible = true;
                lblErrorLine.Visible = true;
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
