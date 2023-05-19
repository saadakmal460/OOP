using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Ghost
    {
        public void Move()
        {

        }

        public void MoveHorizontailly()
        {
            
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
            Console.Write(" ");
        }
        public void Draw()
        {
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
