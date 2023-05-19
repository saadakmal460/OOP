using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Cell
    {
        public bool IsGhostPresent(char ghostCharacter)
        {
            if (value == ghostCharacter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPacmanPresent()
        {
            if(value == 'p')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetY()
        {
            return y;
        }
        public int GetX()
        {
            return x;
        }
        public void SetValue(char value)
        {
            this.value = value;
        }
        public char GetValue()
        {
            return value;
        }
        public Cell(int x , int y  , char value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
        public char value;
        public int x;
        public int y;
    }
}
