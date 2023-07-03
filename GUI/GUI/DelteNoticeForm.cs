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
    public partial class DelteNoticeForm : Form
    {
        public DelteNoticeForm()
        {
            InitializeComponent();
        }

        private void DelteNoticeForm_Load(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            foreach (Notices i in Admin.GetNoticesList())
            {
                comboBoxTitle.Items.Add(i.GetTitle());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string title = comboBoxTitle.Text;
            if(title != null)
            {
                lblErrorLine.Text = "Delted Sucessfully";
                lblErrorLine.ForeColor = Color.Green;
                lblErrorLine.Visible = true;
                Delete(title);
                NoticesDL.StoreNoticesInFile(ExtraBL.GetNoticesPath());
            }
            else
            {
                lblErrorLine.Text = "Please select a title!!";
                lblErrorLine.ForeColor = Color.Crimson;
                lblErrorLine.Visible = true;
            }
        }

        private void Delete(string title)
        {
            for(int i=0;i< Admin.GetNoticesList().Count;i++)
            {
                if(title == Admin.GetNoticesList()[i].GetTitle())
                {
                    NoticesDL.RemoveANotice(Admin.GetNoticesList() , i);
                    break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new NoticesForm();
            f.Show();
        }
    }
}
