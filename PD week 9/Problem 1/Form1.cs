using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("C++");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
