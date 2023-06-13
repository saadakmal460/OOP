using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int count  = Colour.Increment();
            ChangeColor(count);

        }


        private void ChangeColor(int count)
        {
            if (count == 1)
            {
                Box1.BackColor = Color.Blue;
            }
            if (count == 2)
            {
                Box1.BackColor = Color.Green;
            }
            if(count == 3)
            {
                Box1.BackColor = Color.Red;
            }
        }
        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int count = Colour.Decrement();
            ChangeColor(count);
        }
    }
}
