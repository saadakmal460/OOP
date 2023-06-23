using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    abstract class Ghost : GameObject
    {
        public GameDirection direction;
        public Ghost(char DisplayCharacter, GameObjectType type): base(DisplayCharacter, type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.type = type;
        }
        public abstract GameCell MoveGhost();
    }
}
