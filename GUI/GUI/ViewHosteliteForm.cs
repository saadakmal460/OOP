using Buisness_Application.BL;
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
    public partial class ViewHosteliteForm : Form
    {
        public ViewHosteliteForm()
        {
            InitializeComponent();
            List<User> sortedUserList = UserDL.GetSortedList();

            
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("RollNumber", "Roll Number");
            dataGridView1.Columns.Add("CNIC", "CNIC");
            dataGridView1.Columns.Add("City", "City");

            dataGridView1.Columns["Name"].Width = 200;
            dataGridView1.Columns["RollNumber"].Width = 200;
            dataGridView1.Columns["CNIC"].Width = 200;
            dataGridView1.Columns["City"].Width = 190;

            
            foreach (User user in sortedUserList)
            {
                if (user is Hostelite)
                {
                    Hostelite hostelite = (Hostelite)user;

                    
                    DataGridViewRow row = new DataGridViewRow();

                    
                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.GetUsername();
                    row.Cells.Add(nameCell);

                    DataGridViewCell rollNumberCell = new DataGridViewTextBoxCell();
                    rollNumberCell.Value = hostelite.GetRollNumber();
                    row.Cells.Add(rollNumberCell);

                    DataGridViewCell cnicCell = new DataGridViewTextBoxCell();
                    cnicCell.Value = hostelite.GetCnic();
                    row.Cells.Add(cnicCell);

                    DataGridViewCell cityCell = new DataGridViewTextBoxCell();
                    cityCell.Value = hostelite.GetCity();
                    row.Cells.Add(cityCell);

                    
                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AdminForm();
            f.Show();
        }
    }
}
