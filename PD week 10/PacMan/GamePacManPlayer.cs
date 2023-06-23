using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(char displayCharacter, GameCell CurrentCell , GameObjectType type) : base(displayCharacter, type)        
        {
            this.DisplayCharacter = displayCharacter;
            this.CurrentCell = CurrentCell;
            this.type = type;
        }

        public GameCell Move(GameDirection direction)
        {
            return this.CurrentCell.NextCell(direction);
        }

        
    }
}
