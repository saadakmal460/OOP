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

        GameEnemyRandom r;
        GameCell fireCell;
        GameFire f;
        int playerCounter = 0;

        List<GameEnemy> enemies = new List<GameEnemy>();
        List<GameFire> fire = new List<GameFire>();
        public GameForm()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 12, 17);
            GameCell startCell = new GameCell(6, 3, grid);
            GameCell HorizontalEnemy1cell = new GameCell(2, 3, grid);
            GameCell HorizontalEnemy2cell = new GameCell(5, 3, grid);
            GameCell enemy2cell = new GameCell(3, 4, grid);
            GameCell enemy3cell = new GameCell(4, 5, grid);

            Image playerImage = GameClass.getGameObjectImage('p');
            Image enemyImage = GameClass.getGameObjectImage('a');
            Image enemyImage2 = GameClass.getGameObjectImage('c');
            
            player = new GamePLayer(playerImage, startCell);
            horizontalEnemy1 = new GameEnemyHorizontal(enemyImage , HorizontalEnemy1cell, GameObjectType.ENEMY, GameDirection.Left);
            //horizontalEnemy2 = new GameEnemyHorizontal(enemyImage, HorizontalEnemy2cell, GameObjectType.ENEMY, GameDirection.Right);

            //r = new GameEnemyRandom(enemyImage2, enemy2cell, GameObjectType.ENEMY, GameDirection.Left);

            enemies.Add(horizontalEnemy1);
            //enemies.Add(horizontalEnemy2);
            //enemies.Add(r);

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

            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);

            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);

            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);

            }

            playerCounter++;
            if(Keyboard.IsKeyPressed(Key.Space))
            {
                if (playerCounter >= 3)
                {
                    fireCell = new GameCell(player.CurrentCell.X, player.CurrentCell.Y, grid);
                    f = new GameFire(Properties.Resources.bullet2Bg, GameObjectType.Fire, GameDirection.Up, fireCell);
                    fire.Add(f);
                    playerCounter = 0;
                }

            }
            
            foreach(GameFire i in fire)
            {
                i.MovePlayerFire(grid);
                if (!i.GetFlag())
                {
                    fire.Remove(i);
                    i.CurrentCell.PictureBox.Image = Properties.Resources.simplebox;
                    break;
                }

                
            }

            
            
            foreach (GameEnemy i in enemies)
            {
                i.MoveGhost(grid);
                
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int valueX = rand.Next(1, 6);
            int valueY = rand.Next(1, 6);
            GameCell start = new GameCell(valueY, valueX, grid);
            Image enemyImage = GameClass.getGameObjectImage('a');
            GameEnemyHorizontal enemy = new GameEnemyHorizontal(enemyImage, start, GameObjectType.ENEMY, GameDirection.Left);
            enemies.Add(enemy);


        }
    }
}
