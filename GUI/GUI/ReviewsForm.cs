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
    public partial class ReviewsForm : Form
    {
        public ReviewsForm()
        {
            InitializeComponent();

            ShowReviews();
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowReviews()
        {
            int Namex = 374;
            int Namey = 185;

            int reviewX = 1061;
            int reviewY = 185;

            int picX = 686;
            int picY = 185;

            

            int count = 0;
            foreach (Reviews i in Hostelite.GetReviewList())
            {
                Label newLabel = new Label();
                Label reviewLabel = new Label();
                PictureBox pictureBox = new PictureBox();

                newLabel.Text = i.GetName();
                reviewLabel.Text = i.GetReviews();

                newLabel.Location = new Point(Namex, Namey + count);
                reviewLabel.Location = new Point(reviewX, reviewY + count);

                Image starPath = returnPath(i.GetRating());

                pictureBox.Image = starPath;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(picX, picY + count);
                pictureBox.Size = new Size(139, 26);


                Controls.Add(newLabel);
                Controls.Add(reviewLabel);
                Controls.Add(pictureBox);
                count = count + 79;
            }
        }

        public Image returnPath(string GetRating)
        {
            Image starPath = null;
            if (GetRating != null)
            {
                if (int.Parse(GetRating) == 1)
                {
                    starPath = Image.FromFile("C:\\Users\\Saad\\Downloads\\1star.png");
                }

                else if (int.Parse(GetRating) == 2)
                {
                    starPath = Image.FromFile("C:\\Users\\Saad\\Downloads\\2star.png");
                }

                else if (int.Parse(GetRating) == 3)
                {
                    starPath = Image.FromFile("C:\\Users\\Saad\\Downloads\\3stars.png");
                }

                else if (int.Parse(GetRating) == 4)
                {
                    starPath = Image.FromFile("C:\\Users\\Saad\\Downloads\\4stars.png");
                }

                else if (int.Parse(GetRating) == 5)
                {
                    starPath = Image.FromFile("C:\\Users\\Saad\\Downloads\\5s.png");
                }
            }
            return starPath;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new AdminForm();
            f.Show();
        }
    }
}
