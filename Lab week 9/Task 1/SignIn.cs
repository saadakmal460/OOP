using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_1.BL;
using Task_1.DL;

namespace Task_1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {
            NameBox.Text = "";
            PassowrdBox.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string password = PassowrdBox.Text;

            MUser user = new MUser(name, password);
            bool valid = MUserCRUD.SignIN(user);
            if (valid)
            {
                MessageBox.Show("User is valid");
            }
            else
            {
                MessageBox.Show("User is Invalid");

            }
            ClearData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
            Form f = new SignInSignUp();
            f.Show();
        }
    }
}
