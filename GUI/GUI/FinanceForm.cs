using Buisness_Application.BL;
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

        private void linkAddOffical_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new AddExpenseForm();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LoginFrom();
            f.Show();
        }

        private void linklblRevene_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new AddRevenueForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new ViewReportForm();
            f.Show();
            this.Hide();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Form f = new RevenueForm();
            f.Show();
            this.Hide();
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            ExtraBL.SetFlag(false);
        }

        private void linklblRemoveExpense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new RemoveExpenseForm();
            f.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new RemoveRevenueForm();
            f.Show();
            this.Hide();
        }
    }
}
