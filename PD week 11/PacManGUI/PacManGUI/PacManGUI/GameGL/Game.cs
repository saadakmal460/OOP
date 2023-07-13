﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan.GameGL
{
    public class Game
    {
        static int score = 0;
        static bool flag;
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
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

        public static void SetFlag(bool f)
        {
            flag = f;
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
            Image img = PacManGUI.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = PacManGUI.Properties.Resources.pacman_open;
            }

            return img;
        }
    }
}
