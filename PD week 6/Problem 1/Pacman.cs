using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Pacman
    {
        public void MoveLeft(Cell current , Cell next)
        {
            
        }
        public void PrintScore()
        {
            Console.SetCursorPosition(100, 10);
            Console.Write("Score is: " + score);
        }
        public void Move()
        {

        }
        public void Remove()
        {
            Console.SetCursorPosition(py, px);
            Console.Write(" ");
        }
        public void Draw()
        {
            Console.SetCursorPosition(py, px);
            Console.Write("P");
        }
        public Pacman(int px , int py , int score , Grid maze)
        {
            this.px = px;
            this.py = py;
            this.score = score;
            this.maze = maze;
        }
        public int px;
        public int py;
        public int score;
        public Grid maze;

    }
}
