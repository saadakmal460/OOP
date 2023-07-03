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
    public partial class MessForm : Form
    {
        public MessForm()
        {
            InitializeComponent();
        }

        private void linkAddHostelite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form f = new ViewMessForm();
            f.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }

        private void linkUpdateRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new UpdateMessForm();
            f.Show();
            this.Close();
        }
    }
}
