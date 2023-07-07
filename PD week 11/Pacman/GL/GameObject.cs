using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class GameObject
    {
        public char DisplayCharacter;
        public Image charcter;
        public GameCell CurrentCell;
        public GameObjectType type;

        public GameObject(char DisplayCharacter, GameObjectType type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.type = type;
        }

        public GameObject(Image charcter, GameObjectType type)
        {
            this.charcter = charcter;
            this.type = type;

        }
    }
}
