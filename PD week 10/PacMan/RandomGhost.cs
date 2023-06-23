using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class RandomGhost : Ghost
    {
        public RandomGhost(char DisplayCharacter, GameCell cell, GameObjectType type, GameDirection direction) : base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.type = type;
        }


        public override GameCell MoveGhost()
        {
            Random r = new Random();
            int value = r.Next(4);
            
            if(value == 0)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x - 1, CurrentCell.y);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
            }
            else if(value == 1)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x + 1, CurrentCell.y);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
            }

            else if(value == 2)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x, CurrentCell.y-1);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
            }

            else if (value == 3)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x, CurrentCell.y + 1);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
            }

            return null;
        }

    }
}
