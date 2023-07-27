using Buisness_Application.BL;
using GUI.DL;
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
    public partial class FinancialRecordForm : Form
    {
        public FinancialRecordForm()
        {
            InitializeComponent();
        }

        private void linkPayemntRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new ViewReportForm();
            f.Show();
            this.Close();
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ExtraBL.GetRole() == "admin")
            {
                this.Close();
                Form f = new AdminForm();
                f.Show();
            }

            else if (ExtraBL.GetRole() == "Finance")
            {
                this.Close();
                Form f = new FinanceForm();
                f.Show();
            }


        }

        private void FinancialRecordForm_Load(object sender, EventArgs e)
        {
            ExtraBL.SetFlag(true);
        }

        private void linkAddHostelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new GraphicalAnalysisForm();
            f.Show();
            this.Close();
        }
    }
}
