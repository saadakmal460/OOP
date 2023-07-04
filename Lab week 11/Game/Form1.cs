using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace Game
{
    public partial class Form1 : Form
    {
        List<PictureBox> playerFires = new List<PictureBox>();
        List<PictureBox> EnemyFires = new List<PictureBox>();
        List<PictureBox> metiorsList = new List<PictureBox>();


        PictureBox enemy1;
        PictureBox enemy2;
        Random rand = new Random();
        string direction1 = "left";
        string direction2 = "right";
        int timer = 0;
        int timer2 = 0;
        int timer3 = 0;
        int metiors = 0;
        bool enemy1Alive = true;
        bool enemy2Alive = true;
        bool playerAlive = true;

        public Form1()
        { 
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Left = player.Left + 25;
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Left = player.Left - 25;
            }

            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.Top = player.Top - 20;
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.Top = player.Top + 20;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                timer3++;

                if (timer3 == 4)
                {
                    GenerateBullets();
                    timer3 = 0;
                }
            }
            MoveBullets();
            RemoveBullets();
            MoveEnemy(enemy1, ref direction1);
            MoveEnemy(enemy2, ref direction2);
            GenerateEnemyBullets();
            MoveFires();
            RemoveEnemyBullets();
            DestroyEnemy();
            DecreaseHealth();
            progressBar();
            GenerateMetiors();
            MetiorHit();

        }       


        private void progressBar()
        {
            progressBar1.Top = player.Top + 100;
            progressBar1.Left = player.Left;
        }
        private void DecreaseHealth()
        {
            foreach (PictureBox i in EnemyFires)
            {
                if (i.Bounds.IntersectsWith(player.Bounds))
                {
                    if (progressBar1.Value > 0)
                    {
                        progressBar1.Value = progressBar1.Value - 1;
                    }
                    if (progressBar1.Value <= 0)
                    {
                        playerAlive = false;
                        player.Hide();
                        break;
                    }

                }
                            
            }
        }

        private void MetiorHit()
        {
            foreach (PictureBox i in metiorsList)
            {
                if (i.Bounds.IntersectsWith(player.Bounds))
                {
                    if (progressBar1.Value > 10)
                    {
                        progressBar1.Value = progressBar1.Value - 10;
                    }
                    if(progressBar1.Value == 10)
                    {
                        progressBar1.Value = 0;
                    }
                    if (progressBar1.Value <= 0)
                    {
                        playerAlive = false;
                        player.Hide();
                        break;
                    }

                }

            }

        }
        


        private void RemoveEnemyBullets()
        {
            for (int i = 0; i < EnemyFires.Count; i++)
            {
                if (EnemyFires[i].Top > this.Height)
                {
                    EnemyFires[i].Visible = false;
                    EnemyFires.Remove(EnemyFires[i]);
                }
               
            }
        }
        private void MoveEnemy(PictureBox enemy, ref string direction)
        {
            if (direction == "right")
            {
                enemy.Left = enemy.Left + 20;
            }
            if (direction == "left")
            {
                enemy.Left = enemy.Left - 20;
            }
            if (enemy.Left + enemy.Width > this.Width)
            {
                direction = "left";
            }
            if (enemy.Left <= 2)
            {
                direction = "right";
            }
        }
        private PictureBox CreateEnemies(Image img)
        {

            PictureBox enemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int right = rand.Next(5, img.Height + 20);

            enemy.Left = left;
            enemy.Top = Top;
            enemy.Width = img.Width;
            enemy.Height = img.Height;
            enemy.BackColor = Color.Transparent;
            enemy.Image = img;

            return enemy;
        }
        private void RemoveBullets()
        {
            for (int i = 0; i < playerFires.Count; i++)
            {
                if (playerFires[i].Bottom < 0)
                {
                    
                    playerFires.Remove(playerFires[i]);

                }
            }

        }
        private void MoveBullets()
        {
            foreach (PictureBox i in playerFires)
            {
                i.Top = i.Top - 20;
            }
        }
        private void GenerateBullets()
        {
            PictureBox fire = new PictureBox();
            Image fireImage = Game.Properties.Resources.laserBlue12;
            fire.Image = fireImage;
            fire.Width = fireImage.Width;
            fire.Height = fireImage.Height;
            fire.BackColor = Color.Transparent;
            fire.Left = player.Left + player.Width / 2;
            fire.Top = player.Top - 70;
            playerFires.Add(fire);
            this.Controls.Add(fire);
        }

        private PictureBox CreateBullet(Image fireImage, PictureBox pb)
        {
            PictureBox fire = new PictureBox();
            fire.Image = fireImage;
            fire.Width = fireImage.Width;
            fire.Height = fireImage.Height;
            fire.BackColor = Color.Transparent;
            fire.Left = pb.Left + pb.Width / 2;
            fire.Top = pb.Top + 70;
            return fire;
        }
        
        private void DestroyEnemy()
        {
            foreach (PictureBox i in playerFires)
            {
                if (i.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    enemy1.Hide();
                    enemy1Alive = false;
                }
                if (i.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    enemy2.Hide();
                    enemy2Alive = false;
                }
            }
        }
        private void GenerateEnemyBullets()
        {
            timer++;
            timer2++;
            if (enemy1Alive)
            {
                if (timer == 10)
                {
                    Image fireImage = Properties.Resources.laserRed13;
                    PictureBox pb = CreateBullet(fireImage, enemy1);
                    this.Controls.Add(pb);
                    EnemyFires.Add(pb);
                    timer = 0;
                }
            }
            if (enemy2Alive)
            {
                if (timer2 == 7)
                {
                    Image fireImage = Properties.Resources.laserRed13;
                    PictureBox pb = CreateBullet(fireImage, enemy2);
                    this.Controls.Add(pb);
                    EnemyFires.Add(pb);
                    timer2 = 0;
                }
            }
        }

        private void MoveFires()
        {
            foreach (PictureBox i in EnemyFires)
            {
                i.Top = i.Top + 20;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enemy1 = CreateEnemies(Properties.Resources.enemyBlack3);
            enemy2 = CreateEnemies(Properties.Resources.enemyGreen2);
            this.Controls.Add(enemy1);
            this.Controls.Add(enemy2);
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(!enemy1Alive && !enemy2Alive)
            {
                timer4.Enabled = false;
                MessageBox.Show("You Won");
                this.Close();
            }
            else if(!playerAlive)
            {
                timer4.Enabled = false;
                MessageBox.Show("You Lose");
                this.Close();
            }
        }

        private PictureBox CreateMetiors(Image img)
        {
            PictureBox enemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int right = rand.Next(0, img.Height + 20);

            enemy.Left = left;
            enemy.Top = Top;
            enemy.Width = img.Width;
            enemy.Height = img.Height;
            enemy.BackColor = Color.Transparent;
            enemy.Image = img;

            return enemy;
        }
        private void GenerateMetiors()
        {
            metiors++;
            if(metiors > 30)
            {
                Image img = Properties.Resources.meteorGrey_big4;
                PictureBox pb = CreateMetiors(img);
                metiorsList.Add(pb);
                this.Controls.Add(pb);
                metiors = 0;
            }

            foreach(PictureBox i in metiorsList)
            {
                i.Top = i.Top + 20;
            }
        }
    }
}
