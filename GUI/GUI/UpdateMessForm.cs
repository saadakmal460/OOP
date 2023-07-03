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
    public partial class UpdateMessForm : Form
    {
        public UpdateMessForm()
        {
            InitializeComponent();
            AddDaysOfWeek();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDaysOfWeek()
        {
            foreach(Mess i in Admin.GetMessList())
            {
                comboBoxDay.Items.Add(i.GetDay());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string day = comboBoxDay.Text;
            string dish = txtDish.Text;
            bool flag = Validations.ValidateCity(dish);
            foreach(Mess i in Admin.GetMessList())
            {
                if(day == i.GetDay())
                {
                    i.SetDish(dish);
                    break;
                }
            }
            

            if(flag)
            {
                lblErrorLine.Visible = true;
                lblErrorLine2.Visible = false;
                MessCRUD.StoreMessMenuInFile(ExtraBL.GetMessPath());

            }
            else
            {
                lblErrorLine2.Visible = true;
                lblErrorLine.Visible = false;

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new MessForm();
            f.Show();
        }

        private void UpdateMessForm_Load(object sender, EventArgs e)
        {

        }
    }
}
