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
    public partial class SearchByNameForm : Form
    {
        public SearchByNameForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtUsename.Text;
            bool flag = false;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            foreach (User user in UserDL.GetUserList())
            {
                if (user is Hostelite)
                {
                    if(name == user.GetUsername())
                    {
                        dataGridView1.Columns.Add("Name", "Name");
                        dataGridView1.Columns.Add("RollNumber", "Roll Number");
                        dataGridView1.Columns.Add("CNIC", "CNIC");
                        dataGridView1.Columns.Add("City", "City");

                        dataGridView1.Columns["Name"].Width = 150;
                        dataGridView1.Columns["RollNumber"].Width = 150;
                        dataGridView1.Columns["CNIC"].Width = 150;
                        dataGridView1.Columns["City"].Width = 150;
                        DataGridViewRow row = new DataGridViewRow();

                        Hostelite hostelite = (Hostelite)user;

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

                        flag = true;
                        dataGridView1.Rows.Add(row);
                        break;
                    }
                    
                }
            }
            dataGridView1.ReadOnly = true;

            if(!flag)
            {
                lblerror.Visible = true;
            }
            else
            {
                lblerror.Visible = false;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new SearchHosteliteForm();
            f.Show();
        }

        private void SearchByNameForm_Load(object sender, EventArgs e)
        {

        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
