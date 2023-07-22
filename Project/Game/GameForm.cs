using EZInput;
using Game.GameGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {

        GameGrid grid;
        GamePLayer player;


        GameEnemyHorizontal horizontalEnemy1;
        GameEnemyHorizontal horizontalEnemy2;
        GameEnemyHorizontal horizontalEnemy3;
        GameEnemyHorizontal horizontalEnemy4;
        GameEnemyHorizontal horizontalEnemy5;


        GameEnemyRandom randomEnemy1;
        GameEnemyRandom randomEnemy2;
        GameEnemyRandom randomEnemy3;

        GameEnemyBoss boss;



        GameCell playerFireCell;

        GameCell randomEnemy1FireCell;
        GameCell randomEnemy2FireCell;
        GameCell randomEnemy3FireCell;

        GameCell horizontalEnemy1FireCell;
        GameCell horizontalEnemy2FireCell;
        GameCell horizontalEnemy3FireCell;
        GameCell horizontalEnemy4FireCell;
        GameCell horizontalEnemy5FireCell;

        GameCell bossFireCell;


        GameFire playerFire;

        GameFire randomEnemy1Fire;
        GameFire randomEnemy2Fire;
        GameFire randomEnemy3Fire;

        GameFire horizontalEnemy1Fire;
        GameFire horizontalEnemy2Fire;
        GameFire horizontalEnemy3Fire;
        GameFire horizontalEnemy4Fire;
        GameFire horizontalEnemy5Fire;

        GameFire bossFire;


        int playerFireCounter = 0;
        int extraHorizontalEnemyCounter = 0;
        int extraRandomEnemyCounter = 0;
        int randomEnemyFireCount = 0;
        int horizontalEnemyFireCounter = 0;
        int bossFireCount = 0;
        int playerLivesCount = 3;

        bool bossFlag = false;

       
        List<GameEnemy> enemies = new List<GameEnemy>();
        List<GameFire> fire = new List<GameFire>();
        List<GameFire> enemyFire2 = new List<GameFire>();

        public GameForm()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            grid = new GameGrid("maze.txt", 12, 17);
            
            GameCell startCell = new GameCell(6, 3, grid);
            GameCell HorizontalEnemy1cell = new GameCell(2, 3, grid);
            GameCell HorizontalEnemy2cell = new GameCell(5, 3, grid);
            GameCell enemy2cell = new GameCell(2, 3, grid);
            

            Image playerImage = GameClass.getGameObjectImage('p');
            Image enemyImage = GameClass.getGameObjectImage('a');
            Image enemyImage2 = GameClass.getGameObjectImage('c');
            
            player = new GamePLayer(playerImage, startCell);
            horizontalEnemy1 = new GameEnemyHorizontal(enemyImage , HorizontalEnemy1cell, GameObjectType.ENEMY, GameDirection.Left);
            horizontalEnemy2 = new GameEnemyHorizontal(enemyImage, HorizontalEnemy2cell, GameObjectType.ENEMY, GameDirection.Right);
            
            randomEnemy1 = new GameEnemyRandom(enemyImage2, enemy2cell, GameObjectType.ENEMY, GameDirection.Left);

            GameCell bossCell = new GameCell(2, 2, grid);
            Image bossImage = GameClass.getGameObjectImage('b');
            boss = new GameEnemyBoss(bossImage, bossCell, GameObjectType.ENEMY, GameDirection.Left);


            enemies.Add(horizontalEnemy1);
            enemies.Add(horizontalEnemy2);
            enemies.Add(randomEnemy1);

            


            printMaze(grid);

        }

        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    if (cell.PictureBox != null)
                    {
                        this.Controls.Add(cell.PictureBox);
                    }


                }

            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
                if (!player.GetFlag() && progressBar1.Value >=20)
                {
                    progressBar1.Value -= 20;
                    player.SetPlayerFlag(true);
                }
            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
                if (!player.GetFlag() && progressBar1.Value >= 20)
                {
                    progressBar1.Value -= 20;
                    player.SetPlayerFlag(true);
                }
            }

            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
                if (!player.GetFlag() && progressBar1.Value >= 20)
                {
                    progressBar1.Value -= 20;
                    player.SetPlayerFlag(true);
                }
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
                if (!player.GetFlag() && progressBar1.Value >= 20)
                {
                    progressBar1.Value -= 20;
                    player.SetPlayerFlag(true);
                }
            }

            if(Keyboard.IsKeyPressed(Key.Space))
            {
                GeneratePlayerBullet();
                

            }

            if(progressBar1.Value <= 20 && playerLivesCount == 3)
            {
                pbHeart3.Hide();
                progressBar1.Value = 100;
                playerLivesCount--;
            }

            if (progressBar1.Value <= 20 && playerLivesCount == 2)
            {
                pbHeart2.Hide();
                playerLivesCount--;
                progressBar1.Value = 100;
            }

            if (progressBar1.Value <= 20 && playerLivesCount == 1)
            {
                pbHeart1.Hide();
                playerLivesCount--;
               
            }

            if (playerLivesCount <= 0)
            {
                gameLoop.Enabled = false;
                MessageBox.Show("You Losse");
                this.Close();
            }


            //Moving player fires
            foreach (GameFire i in fire)
            {
                i.MovePlayerFire(grid);  
                if (!i.GetFlag())
                {
                    fire.Remove(i);
                    i.CurrentCell.PictureBox.Image = Properties.Resources.transparent;
                    break;
                }
                
            }

            //moving enemies
            foreach (GameEnemy i in enemies)
            {
                i.MoveGhost(grid);
                if (!i.GetFlag2())
                {
                    enemies.Remove(i);
                    i.CurrentCell.PictureBox.Image = Properties.Resources.transparent;
                    break;
                }
            }

            //moving enemies bullets
            foreach (GameFire i in enemyFire2)
            {
                i.MoveEnemyFire(grid);
                if (!i.GetFlag())
                {
                    enemyFire2.Remove(i);
                    i.CurrentCell.PictureBox.Image = Properties.Resources.transparent;
                    break;
                }
            }

            if(enemies.Count == 1 && bossFlag)
            {
                
                enemies.Add(boss);
            }

            if(!GameClass.GetBossFlag())
            {
                gameLoop.Enabled = false;
                MessageBox.Show("You win");
                this.Close();
            }

            

            //generating enemies bullets
            GenerateRandomEnemyBullet();
            GenerateHorizontalEnemyBullet();
            GenerateBossBullets();

            //incrementing counter
            playerFireCounter++;
            randomEnemyFireCount++;
            horizontalEnemyFireCounter++;
            bossFireCount++;
        }


        
        private void GenerateHorizontalEnemyBullet()
        {
            
            if (horizontalEnemyFireCounter >= 15)
            {
                
                if (horizontalEnemy1 != null && enemies.Contains(horizontalEnemy1))
                {
                    horizontalEnemy1FireCell = new GameCell(horizontalEnemy1.CurrentCell.X, horizontalEnemy1.CurrentCell.Y, grid);
                    horizontalEnemy1Fire = new GameFire(Properties.Resources.laserRed13, GameObjectType.EnemyFire, horizontalEnemy1FireCell);
                    enemyFire2.Add(horizontalEnemy1Fire);
                }

                if (horizontalEnemy2 != null && enemies.Contains(horizontalEnemy2))
                {
                    horizontalEnemy2FireCell = new GameCell(horizontalEnemy2.CurrentCell.X, horizontalEnemy2.CurrentCell.Y, grid);
                    horizontalEnemy2Fire = new GameFire(Properties.Resources.laserRed13, GameObjectType.EnemyFire, horizontalEnemy2FireCell);
                    enemyFire2.Add(horizontalEnemy2Fire);
                }

                if (horizontalEnemy3 != null && enemies.Contains(horizontalEnemy3))
                {
                    horizontalEnemy3FireCell = new GameCell(horizontalEnemy3.CurrentCell.X, horizontalEnemy3.CurrentCell.Y, grid);
                    horizontalEnemy3Fire = new GameFire(Properties.Resources.laserRed13, GameObjectType.EnemyFire, horizontalEnemy3FireCell);
                    enemyFire2.Add(horizontalEnemy3Fire);
                }

                if (horizontalEnemy4 != null && enemies.Contains(horizontalEnemy4))
                {
                    horizontalEnemy4FireCell = new GameCell(horizontalEnemy4.CurrentCell.X, horizontalEnemy4.CurrentCell.Y, grid);
                    horizontalEnemy4Fire = new GameFire(Properties.Resources.laserRed13, GameObjectType.EnemyFire, horizontalEnemy4FireCell);
                    enemyFire2.Add(horizontalEnemy4Fire);
                }

                if (horizontalEnemy5 != null && enemies.Contains(horizontalEnemy5))
                {
                    horizontalEnemy5FireCell = new GameCell(horizontalEnemy5.CurrentCell.X, horizontalEnemy5.CurrentCell.Y, grid);
                    horizontalEnemy5Fire = new GameFire(Properties.Resources.laserRed13, GameObjectType.EnemyFire, horizontalEnemy5FireCell);
                    enemyFire2.Add(horizontalEnemy5Fire);
                }

                horizontalEnemyFireCounter = 0;
            }
        }

        private void GenerateBossBullets()
        {
            if (bossFireCount >= 7)
            {
                if (boss != null && enemies.Contains(boss))
                {
                    bossFireCell = new GameCell(boss.CurrentCell.X, boss.CurrentCell.Y, grid);
                    bossFire = new GameFire(Properties.Resources.laserGreen02, GameObjectType.EnemyFire, bossFireCell);
                    enemyFire2.Add(bossFire);

                }
                bossFireCount = 0;
            }
        }
        private void GenerateRandomEnemyBullet()
        {
            if (randomEnemyFireCount >= 8)
            {
                if (randomEnemy1 != null && enemies.Contains(randomEnemy1))
                {
                    randomEnemy1FireCell = new GameCell(randomEnemy1.CurrentCell.X, randomEnemy1.CurrentCell.Y, grid);
                    randomEnemy1Fire = new GameFire(Properties.Resources.laserBlue13, GameObjectType.EnemyFire, randomEnemy1FireCell);
                    enemyFire2.Add(randomEnemy1Fire);

                }
                if (randomEnemy2 != null && enemies.Contains(randomEnemy2))
                {
                    randomEnemy2FireCell = new GameCell(randomEnemy2.CurrentCell.X, randomEnemy2.CurrentCell.Y, grid);
                    randomEnemy2Fire = new GameFire(Properties.Resources.laserBlue13, GameObjectType.EnemyFire, randomEnemy2FireCell);
                    enemyFire2.Add(randomEnemy2Fire);

                }
                if (randomEnemy3 != null && enemies.Contains(randomEnemy3))
                {
                    randomEnemy3FireCell = new GameCell(randomEnemy3.CurrentCell.X, randomEnemy3.CurrentCell.Y, grid);
                    randomEnemy3Fire = new GameFire(Properties.Resources.laserBlue13, GameObjectType.EnemyFire, randomEnemy3FireCell);
                    enemyFire2.Add(randomEnemy3Fire);

                }
                randomEnemyFireCount = 0;
            }
        }
        private void GeneratePlayerBullet()
        {
            if (playerFireCounter >= 3)
            {
                playerFireCell = new GameCell(player.CurrentCell.X, player.CurrentCell.Y, grid);
                playerFire = new GameFire(Properties.Resources.bullet2Bg, GameObjectType.Fire, playerFireCell);
                fire.Add(playerFire);
                playerFireCounter = 0;
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            if (extraHorizontalEnemyCounter < 3)
            {
                if (extraHorizontalEnemyCounter == 0)
                {
                    Random rand = new Random();
                    int valueX = rand.Next(1, 6);
                    int valueY = rand.Next(1, 6);
                    GameCell start = new GameCell(valueY, valueX, grid);
                    Image enemyImage = GameClass.getGameObjectImage('a');
                    horizontalEnemy3 = new GameEnemyHorizontal(enemyImage, start, GameObjectType.ENEMY, GameDirection.Left);
                    enemies.Add(horizontalEnemy3);
                }

                if (extraHorizontalEnemyCounter == 1)
                {
                    Random rand = new Random();
                    int valueX = rand.Next(1, 6);
                    int valueY = rand.Next(1, 6);
                    GameCell start = new GameCell(valueY, valueX, grid);
                    Image enemyImage = GameClass.getGameObjectImage('a');
                    horizontalEnemy4 = new GameEnemyHorizontal(enemyImage, start, GameObjectType.ENEMY, GameDirection.Right);
                    enemies.Add(horizontalEnemy4);
                }

                if (extraHorizontalEnemyCounter == 2)
                {
                    Random rand = new Random();
                    int valueX = rand.Next(1, 6);
                    int valueY = rand.Next(1, 6);
                    GameCell start = new GameCell(valueY, valueX, grid);
                    Image enemyImage = GameClass.getGameObjectImage('a');
                    horizontalEnemy5 = new GameEnemyHorizontal(enemyImage, start, GameObjectType.ENEMY, GameDirection.Left);
                    enemies.Add(horizontalEnemy5);
                }
                extraHorizontalEnemyCounter++;
            }

        }

        private void randomEnemyTimer_Tick(object sender, EventArgs e)
        {
            if (extraRandomEnemyCounter < 2)
            {
                if (extraRandomEnemyCounter == 0)
                {
                    
                    Random rand = new Random();
                    int valueX = rand.Next(1, 6);
                    int valueY = rand.Next(1, 6);
                    GameCell start = new GameCell(valueY, valueX, grid);
                    Image enemyImage = GameClass.getGameObjectImage('c');
                    randomEnemy2 = new GameEnemyRandom(enemyImage, start, GameObjectType.ENEMY, GameDirection.Left);
                    enemies.Add(randomEnemy2);
                }

                if (extraRandomEnemyCounter == 1)
                {
                    
                    Random rand = new Random();
                    int valueX = rand.Next(1, 6);
                    int valueY = rand.Next(1, 6);
                    GameCell start = new GameCell(valueY, valueX, grid);
                    Image enemyImage = GameClass.getGameObjectImage('c');
                    randomEnemy3 = new GameEnemyRandom(enemyImage, start, GameObjectType.ENEMY, GameDirection.Right);
                    enemies.Add(randomEnemy3);
                    bossFlag = true;
                }
                extraRandomEnemyCounter++;
            }
        }
    }
}
