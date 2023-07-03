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
    public partial class ViewMessForm : Form
    {
        public ViewMessForm()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewMess()
        {
            List<Mess> m = Admin.GetMessList();


            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("Dish", "Dish");
            

            dataGridView1.Columns["Day"].Width = 100;
            dataGridView1.Columns["Dish"].Width = 100;
            


            foreach (Mess i in m)
            {

                DataGridViewRow row = new DataGridViewRow();


                DataGridViewCell day = new DataGridViewTextBoxCell();
                day.Value = i.GetDay();
                row.Cells.Add(day);

                DataGridViewCell dish = new DataGridViewTextBoxCell();
                dish.Value = i.GetDish();
                row.Cells.Add(dish);



                dataGridView1.Rows.Add(row);
                
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new MessForm();
            f.Show();
        }

        private void ViewMessForm_Load(object sender, EventArgs e)
        {
            ViewMess();
        }
    }
}
