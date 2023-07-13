using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    public class GameClass
    {
        static int score = 0;
        static bool flag = true;
        static bool FireFlag = true;
        
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
            return blankGameObject;
        }

        public static void SetFireFlag(bool flag)
        {
            FireFlag = flag;
        }
        public static bool GetFireFlag()
        {
            return FireFlag;
        }
        public static GameObject getCurrentObject(GameCell c)
        {

            GameObject Object = new GameObject(c.CurrentGameObject.GameObjectType, c.CurrentGameObject.Image);

            return Object;
        }

        public static void AddScore()
        {
            score++;

        }

        public static void SetFlag()
        {
            flag = false;
        }
        public static bool GetFlag()
        {
            return flag;
        }
        public static int ReturnScore()
        {
            return score;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = Properties.Resources.vertical2;
            }

            if (displayCharacter == '#')
            {
                img = Properties.Resources.horizontal2;
            }
            if(displayCharacter == 'p')
            {
                img = Properties.Resources.Hero2;
            }
            if(displayCharacter == 'a')
            {
                img = Properties.Resources.enemy1bg;
            }
            if(displayCharacter == 'b')
            {
                img = Properties.Resources.boss;
            }
            if(displayCharacter == 'c')
            {
                img = Properties.Resources.enemy2bg;
            }
            if(displayCharacter == '.')
            {
                img = Properties.Resources.laserBlue12;
            }
            

            return img;
        }
    }
}
