using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    abstract class GameEnemy : GameObject
    {
        public GameDirection direction;
        public bool flag2 = true;
        public GameEnemy(char DisplayCharacter, GameObjectType type) : base(type, DisplayCharacter)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.GameObjectType = type;
        }

        public GameEnemy(Image img, GameObjectType type) : base(type, img)
        {
            this.GameObjectType = type;
            this.Image = img;
        }

        public void SetFlag2()
        {
            flag2 = false;
        }
        public bool GetFlag2()
        {
            return flag2;
        }
        public abstract GameCell MoveGhost(GameGrid grid);
    }
}
