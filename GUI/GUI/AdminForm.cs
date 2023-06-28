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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkAddHostelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new AddHosteliteForm();
            f.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new LoginFrom();
            f.Show();
            this.Close();
        }

        private void linkViewHostelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new ViewHosteliteForm();
            this.Hide();
            f.Show();
        }

        private void linkUpdateRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new UpdateRecordForm();
            this.Hide();
            f.Show();
        }

        private void linkRemoveHostelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new RemoveHosteliteForm();
            f.Show();
            this.Close();
        }

        private void linkAddOffical_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new AddOfficalForm();
            f.Show();
            this.Close();
        }

        private void linkPayemntRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FinancialRecordForm();
            f.Show();
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
