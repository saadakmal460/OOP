using EZInput;
using Pacman.GL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        GamePacManPlayer player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            Image pacManImage = Game.GetImage('P');
            GameCell startCell = grid.GetCell(8, 10);
            player = new GamePacManPlayer(pacManImage, startCell);
            PrintMaze(grid);
        }



        private void PrintMaze(GameGrid g)
        {
            for (int i = 0; i < g.rows; i++)
            {
                for (int j = 0; j < g.colomns; j++)
                {
                    GameCell cell = g.GetCell(i, j);
                    this.Controls.Add(cell.pb);
                }
            }
        }

        private void PacmanTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.MovePacman(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.MovePacman(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.MovePacman(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.MovePacman(GameDirection.Down);
            }
        }
    }
}
