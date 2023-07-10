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

namespace GUI.DL
{
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void linkFinancialReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FinancialRecordForm();
            f.Show();
            this.Close();
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            Form f = new ViewNoticesForm();
            f.Show();
            this.Hide();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            Form f = new FeeStatusForm();
            f.Show();
            this.Hide();
        }
    }
}
