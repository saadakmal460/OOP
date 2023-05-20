using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Ghost
    {
        
        public double CalculateDistance(Cell currrent , Cell Pacman)
        {
            return Math.Sqrt(Math.Pow((currrent.x - Pacman.x), 2) + Math.Pow((currrent.y - Pacman.y), 2));
        }
        public void MoveRandom()
        {
            int value = GenerateRandom();
            if (value == 1)
            {
                if (mazeGrid.maze[x, y + 1].value == ' ' || mazeGrid.maze[x, y + 1].value == '-' || mazeGrid.maze[x,y+1].value == 'P')
                {
                    y++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
            }
            else if (value == 2)
            {
                if (mazeGrid.maze[x, y - 1].value == ' ' || mazeGrid.maze[x, y - 1].value == '-' || mazeGrid.maze[x, y - 1].value == 'P')
                {
                    y--;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
            else if (value == 3)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ' || mazeGrid.maze[x+1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x++;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
            else if (value == 4)
            {
                if (mazeGrid.maze[x-1 , y].value == ' ' || mazeGrid.maze[x-1, y].value == '-' || mazeGrid.maze[x+1, y].value == 'P')
                {
                    x--;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
        }

        public int GenerateRandom()
        {
            Random r = new Random();
            int value = r.Next(5);
            return value;
        }
        public void Move()
        {
          
            if(ghostCharacter == 'H')
            {
                MoveHorizontailly();
            }

            else if(ghostCharacter == 'V')
            {
                MoveVertically();
            }
            
            else if(ghostCharacter == 'R')
            {
                MoveRandom();
            }

        }

        public void MoveVertically()
        {
            if (ghostDirection == "up")
            {
                if (mazeGrid.maze[x - 1, y].value == ' ' || mazeGrid.maze[x - 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x--;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else
                {

                    ghostDirection = "down";
                    
                }
            }
            if (ghostDirection == "down")
            {
                if (mazeGrid.maze[x + 1, y].value == ' ' || mazeGrid.maze[x + 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else
                {
                    ghostDirection = "up";
                    
                }
            }
        }
        public void MoveHorizontailly()
        {
            if (ghostDirection == "left")
            {
                if (mazeGrid.maze[x, y + 1].value == ' ' || mazeGrid.maze[x, y + 1].value == '-' || mazeGrid.maze[x, y + 1].value == 'P')
                {
                    y++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else if(mazeGrid.maze[x, y + 1].value == '|' || mazeGrid.maze[x, y + 1].value != '%' || mazeGrid.maze[x, y + 1].value == '#')
                {

                    ghostDirection = "right";

                }
            }
            if(ghostDirection == "right")
            {
                if (mazeGrid.maze[x, y - 1].value == ' ' || mazeGrid.maze[x, y - 1].value == '-' || mazeGrid.maze[x, y - 1].value == 'P')
                {
                    y--;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else if(mazeGrid.maze[x, y - 1].value == '|' || mazeGrid.maze[x, y - 1].value == '%' || mazeGrid.maze[x, y - 1].value == '#')
                {
                    ghostDirection = "left";
                }
            }
        }
        public float getDelta()
        {
            return deltaChange;
        }
        public void ChangeDelta()
        {
            deltaChange = deltaChange + speed;
        }
        public void Remove()
        {

            Console.SetCursorPosition(y,x);
            Console.Write(previousItem);
        }
        public void Draw()
        {
            Console.SetCursorPosition(y,x);
            Console.Write(ghostCharacter);
        }
        public string GetDirection()
        {
            return ghostDirection;
        }
        public void SetGhostDirection(string Direction)
        {
            ghostDirection = Direction;
        }
        public Ghost(int x , int y , string ghostDirection, char ghostCharacter , float speed, char previousItem, float deltaChange , Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.ghostDirection = ghostDirection;
            this.ghostCharacter = ghostCharacter;
            this.speed = speed;
            this.previousItem = previousItem;
            this.deltaChange = deltaChange;
            this.mazeGrid = mazeGrid;
        }
        public int x;
        public int y;
        public string ghostDirection;
        public char ghostCharacter;
        public float speed;
        public char previousItem;
        public float deltaChange;
        public Grid mazeGrid;
    }
}
