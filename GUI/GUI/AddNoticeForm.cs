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
    public partial class AddNoticeForm : Form
    {
        public AddNoticeForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            string title = txtTitle.Text;
            bool flag = Validations.ValidateCity(title);
            if(!flag)
            {
                lblerrorName.Visible = true;
            }
            else
            {
                lblerrorName.Visible = false;

            }

            string notice = txtNotice.Text;
            bool flag2 = Validations.ValidateNotice(notice);
            if (!flag2)
            {
                lblNotice.Visible = true;
            }
            else
            {
                lblNotice.Visible = false;

            }


            if (flag && flag2)
            {
                lblErrorLine.Text = "Notice Added sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                lblErrorLine.Visible = true;
                Notices n = new Notices(title, notice);
                Admin.AddNotices(n);
                NoticesDL.StoreNoticesInFile(ExtraBL.GetNoticesPath());
            }
            else
            {
                lblErrorLine.Text = "Data was not saved! Check you inputs";
                lblErrorLine.ForeColor = Color.Crimson;
                lblErrorLine.Visible = true;
            }
        }


        private void Clear()
        {
            txtNotice.Text = "";
            txtTitle.Text = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new NoticesForm();
            f.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
