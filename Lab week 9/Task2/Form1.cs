using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Muser> user = new List<Muser>();
            Muser u1 = new Muser("Saad", "123", "1");
            Muser u2 = new Muser("Ahmad", "111", "2");
            Muser u3 = new Muser("Ali", "456", "3");
            user.Add(u1);
            user.Add(u2);
            user.Add(u3);
            dataGridView1.DataSource = user;
        }

        
    }
}
