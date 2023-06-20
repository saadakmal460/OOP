using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType type;

        public GameObject(char DisplayCharacter ,GameObjectType type)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.type = type;
        }

        //public static GameObjectType GetGameObjectType(string charcter)
        //{
            
        //}


    }
}