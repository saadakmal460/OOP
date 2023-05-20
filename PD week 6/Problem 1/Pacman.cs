﻿using System;
using EZInput;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Pacman
    {
        
        public void IncreaseScore()
        {
            if (mazeGrid.maze[px, py].value == '-')
            {
                score++;
            }
        }
        public void MoveDown()
        {
            if (mazeGrid.maze[px + 1, py].value == ' ' || mazeGrid.maze[px+1, py].value == '-')
            {
                px++;
            }
            
        }
        public void MoveUp()
        {
            if (mazeGrid.maze[px-1, py].value == ' ' || mazeGrid.maze[px-1, py].value == '-')
            {
                px--;
            }
            
        }
        public void MoveLeft()
        {
            if (mazeGrid.maze[px, py - 1].value == ' ' || mazeGrid.maze[px, py - 1].value == '-')
            {
                py--;
            }
           
        }
        public void MoveRight()
        {
            if (mazeGrid.maze[px, py + 1].value == ' ' || mazeGrid.maze[px, py + 1].value == '-')
            {
                py++;
            }
            
        }
        public void PrintScore()
        {
            Console.SetCursorPosition(100, 10);
            Console.Write("Score is: " + score);
        }
        public void Move()
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                MoveRight();
                IncreaseScore();
            }
            if(Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                MoveLeft();
                IncreaseScore();
            }
            if(Keyboard.IsKeyPressed(Key.UpArrow))
            {
                MoveUp();
                IncreaseScore();
            }
            if(Keyboard.IsKeyPressed(Key.DownArrow))
            {
                MoveDown();
                IncreaseScore();
            }
            
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
            this.mazeGrid = maze;
        }
        public int px;
        public int py;
        public int score;
        public Grid mazeGrid;

    }
}
