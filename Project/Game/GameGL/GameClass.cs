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
        static bool boss = true;
        
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.transparent);
            return blankGameObject;
        }


        
        public static void SetFireFlag(bool flag)
        {
            FireFlag = false;
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


        public static void BossFlag(bool f)
        {
            flag = f;
        }

        public static bool GetBossFlag()
        {
            return flag;
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
            Image img = Properties.Resources.transparent;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = Properties.Resources.transparent;
            }

            if (displayCharacter == '#')
            {
                img = Properties.Resources.transparent;
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
                img = Properties.Resources.boss1;
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
