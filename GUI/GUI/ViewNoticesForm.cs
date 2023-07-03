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
    public partial class ViewNoticesForm : Form
    {
        public ViewNoticesForm()
        {
            InitializeComponent();
        }

        private void ViewNoticesForm_Load(object sender, EventArgs e)
        {
            ShowNotices();
        }

        private void ShowNotices()
        {
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Notice", "Notice");


            dataGridView1.Columns["Title"].Width = 150;
            dataGridView1.Columns["Notice"].Width = 200;

          

            foreach (Notices i in Admin.GetNoticesList())
            {

                DataGridViewRow row = new DataGridViewRow();


                DataGridViewCell title = new DataGridViewTextBoxCell();
                title.Value = i.GetTitle();
                row.Cells.Add(title);

                DataGridViewCell dish = new DataGridViewTextBoxCell();
                dish.Value = i.GetNotice();
                row.Cells.Add(dish);



                dataGridView1.Rows.Add(row);

                
            }
            dataGridView1.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new NoticesForm();
            f.Show();
        }
    }
}
