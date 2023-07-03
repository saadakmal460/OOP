using Buisness_Application.BL;
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
    public partial class ViewComplaintsForm : Form
    {
        public ViewComplaintsForm()
        {
            InitializeComponent();
        }

        private void ViewComplaintsForm_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Complaint", "Complaint");

            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Complaint"].Width = 200;

            foreach (Complaints i in Hostelite.GetComplaintsList())
            {
                DataGridViewRow row = new DataGridViewRow();


                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = i.GetName();
                row.Cells.Add(nameCell);


                DataGridViewCell complaintsCell = new DataGridViewTextBoxCell();
                complaintsCell.Value = i.GetComplaint();
                row.Cells.Add(complaintsCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }
    }
}
