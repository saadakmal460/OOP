using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class HorizontalGhost : Ghost
    {
        
        public HorizontalGhost(char DisplayCharacter, GameCell cell, GameObjectType type , GameDirection direction) : base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.type = type;
        }

        public override GameCell MoveGhost()
        {


            if(direction == GameDirection.Left)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x , CurrentCell.y - 1);
                if(next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
                else if(next.CurrentGameObject.type == GameObjectType.Wall)
                {
                    direction = GameDirection.Right;
                }
            }

            if(direction == GameDirection.Right)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x, CurrentCell.y + 1);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
                else if (next.CurrentGameObject.type == GameObjectType.Wall)
                {
                    
                    direction = GameDirection.Left;
                }

            }

            return null;


        }
    }
}
