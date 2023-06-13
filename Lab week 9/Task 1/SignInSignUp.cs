using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class SignInSignUp : Form
    {
        public SignInSignUp()
        {
            InitializeComponent();
            string path = "Data.txt";
            DL.MUserCRUD.LoadFromFile(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignInSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CbSignIn.Checked)
            {
                Form f = new SignIn();
                f.Show();
                CbSignIn.Checked = false ;
                
            }

            else
            {
                Form f = new SignUp();
                f.Show();
                CbSignUp.Checked = false;
            }

            this.Hide();
        }
    }
}
