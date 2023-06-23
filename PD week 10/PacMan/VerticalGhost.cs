using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class VerticalGhost : Ghost
    {
        public VerticalGhost(char DisplayCharacter, GameCell cell, GameObjectType type, GameDirection direction) : base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.CurrentCell = cell;
            this.direction = direction;
            this.type = type;
        }
        public override GameCell MoveGhost()
        {


            if (direction == GameDirection.Up)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x -1 , CurrentCell.y);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
                else if (next.CurrentGameObject.type == GameObjectType.Wall)
                {
                    direction = GameDirection.Down;
                }
            }

            if (direction == GameDirection.Down)
            {
                GameCell next = CurrentCell.gameGrid.GetCell(CurrentCell.x + 1, CurrentCell.y);
                if (next.CurrentGameObject.type != GameObjectType.Wall)
                {
                    return next;
                }
                else if (next.CurrentGameObject.type == GameObjectType.Wall)
                {

                    direction = GameDirection.Up;
                }

            }

            return null;


        }
    }
}
