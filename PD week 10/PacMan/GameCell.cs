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
                if (this.x > 0)
                {
                    GameCell next = gameGrid.GetCell(this.x-1 ,this.y);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }
            else if(GameDirection.Down == gameDirection)
            {
                if (this.x < gameGrid.rows - 1)
                {
                    GameCell next = gameGrid.GetCell(this.x + 1, this.y);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }
            else if(GameDirection.Left == gameDirection)
            {
                if(this.y >0)
                {
                    GameCell next = gameGrid.GetCell(this.x, this.y-1);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
               
            }
            else if(GameDirection.Right == gameDirection)
            {
                if(this.y < gameGrid.colomns-1)
                {
                    GameCell next = gameGrid.GetCell(this.x , this.y+1);
                    if (next.CurrentGameObject.type != GameObjectType.Wall)
                    {
                        return next;
                    }
                }
            }

            return this;
            
        }
    }
}
