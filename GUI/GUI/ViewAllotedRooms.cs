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
    public partial class ViewAllotedRooms : Form
    {
        public ViewAllotedRooms()
        {
            InitializeComponent();
            
        }

        private void ViewAllotedRooms_Load(object sender, EventArgs e)
        {
            ViewAlloted();
        }


        private void ViewAlloted()
        {
            List<User> sortedUserList = UserDL.GetUserList();


            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("RoomNumber", "Room Number");
            

            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["RoomNumber"].Width = 150;
            


            foreach (User user in sortedUserList)
            {
                if (user is Hostelite)
                {
                    Hostelite hostelite = (Hostelite)user;


                    DataGridViewRow row = new DataGridViewRow();


                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = user.GetUsername();
                    row.Cells.Add(nameCell);

                    DataGridViewCell roomNumberCell = new DataGridViewTextBoxCell();
                    roomNumberCell.Value = hostelite.GetRoomNumber();
                    row.Cells.Add(roomNumberCell);

                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
