using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using PacManGUI.GameGL;

namespace PacManGUI
{
    public partial class Form1 : Form
    {
        List<Ghost> ghost = new List<Ghost>();
        GamePacManPlayer pacman;
        HorizontalGhost g;
        VerticalGhost v;
        GameGrid grid;
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 24, 70);
            Image pacManImage = Game.getGameObjectImage('P');
           
            GameCell startCell = grid.getCell(8, 10);
            GameCell cell1 = grid.getCell(1, 10);
            GameCell cell2 = grid.getCell(3, 3);
            pacman = new GamePacManPlayer(pacManImage, startCell);
            g = new HorizontalGhost(Properties.Resources.ghost_blue,cell1 , GameObjectType.ENEMY , GameDirection.Left);
            v = new VerticalGhost(Properties.Resources.ghost_red , cell2, GameObjectType.ENEMY, GameDirection.Up);
            ghost.Add(g);
            ghost.Add(v);
            printMaze(grid);
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
               
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);          
            //        printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
     

        

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                pacman.move(GameDirection.Down);
            }
            foreach(Ghost i in ghost)
            {
                i.MoveGhost(grid);
            }


        }
    }
}
