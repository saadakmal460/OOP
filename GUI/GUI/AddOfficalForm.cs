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
    public partial class AddOfficalForm : Form
    {
        public AddOfficalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }

        private void linkAddAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form f = new AddAdminForm();
            f.Show();
        }

        private void AddOfficalForm_Load(object sender, EventArgs e)
        {

        }

        private void linklblFinance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new AddFinance();
            f.Show();
            this.Close();
        }
    }
}
