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

namespace Task_1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           
        }
        private void ClearForm()
        {
            NameBox.Text = "";
            PassowrdBox.Text = "";
            RoleBox.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string password = PassowrdBox.Text;
            string role = RoleBox.Text;
            string path = "Data.txt";
            MUser user = new MUser(name, password, role);
            DL.MUserCRUD.AddInList(user);
            DL.MUserCRUD.StoreInFile(user, path);
            MessageBox.Show("Sigup sucessful");
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new SignInSignUp();
            f.Show();
        }
    }
}
