using Buisness_Application.BL;
using Buisness_Application.DL;
using GUI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            
            UserDL.LoadUsersFromFile(ExtraBL.GetUsersPath());
            NoticesDL.LoadNoticesFromFile(ExtraBL.GetNoticesPath());
            MessCRUD.LoadMessMenuFromFile(ExtraBL.GetMessPath());
            ComplaintsDL.LoadComplaintsFromFile(ExtraBL.GetComplaintsPath());
            ReviewsDL.LoadReviewsFromFile(ExtraBL.GetReviewsPath());
            ChallanDL.LoadChallansFromFile(ExtraBL.GetChallanPath());
            FinancialRecordDL.LoadFinancialRecordFromFile(ExtraBL.GetRecordPath());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string name = txtUsename.Text;
            string password = txtPassword.Text;
            User user = new User(name, password);
            string role = user.returnRole();
            
            if(role == "admin")
            {
                Form f = new AdminForm();
                f.Show();
                this.Hide();
                

            }

            else if(role == "hostelite")
            {
                MessageBox.Show("hostelite is valid");
            }

            else if(role == null)
            {
                lblError.Visible = true;
            }

            
        }
    }
}
