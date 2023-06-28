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
    public partial class GraphicalAnalysisForm : Form
    {
        public GraphicalAnalysisForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            RevenueLine();
            ExpenseLine();
        }

        private void GraphicalAnalysisForm_Load(object sender, EventArgs e)
        {

        }

        private void ExpenseLine()
        {
            int expense = FinancialRecordDL.CalculateDigits("Expense");
            if (expense == 3)
            {
                panelE1.Visible = true;
            }
            else if (expense == 4)
            {
                panelE1k.Visible = true;
            }
            else if (expense == 5)
            {
                panelE10K.Visible = true;
            }
            else if (expense == 6)
            {
                panelE100K.Visible = true;
            }
            else if (expense == 7)
            {
                pannelE1M.Visible = true;
            }
        }

        private void RevenueLine()
        {
            int revenue = FinancialRecordDL.CalculateDigits("Revenue");
            
            if(revenue == 3)
            {
                pannel1k.Visible = true;
            }
            else if(revenue == 4)
            {
                pannel5k.Visible = true;
            }
            else if(revenue == 5)
            {
                panel10k.Visible = true;
            }
            else if (revenue == 6)
            {
                panel100k.Visible = true;
            }
            else if (revenue == 7)
            {
                panel1M.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form F = new FinancialRecordForm();
            F.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
