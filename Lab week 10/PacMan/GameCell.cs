using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class GameCell
    {
        public int x;
        public int y;
        public GameObject CurrentGameObject;
        public GameGrid gameGrid;

        public GameCell(int x , int y , GameGrid gameGrid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = gameGrid;
        }

        public GameCell(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        

        public GameCell NextCell(GameDirection gameDirection)
        {
            if(GameDirection.Up == gameDirection)
            {
                x = x - 1;
            }
            else if(GameDirection.Down == gameDirection)
            {
                x = x + 1;
            }
            else if(GameDirection.Left == gameDirection)
            {
                y = y - 1;
            }
            else
            {
                y = y + 1;
            }
            GameCell c = new GameCell(x, y);
            return c;
        }
    }
}
