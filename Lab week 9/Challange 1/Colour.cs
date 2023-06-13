using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class Colour
    {
        private static int colorCount;

        public Colour()
        {
            colorCount = 0;
        }

        

        public static int GetColorCount()
        {
            return colorCount;
        }

        public static int Increment()
        {
            if(colorCount <=2)
            {
                colorCount++;
            }
            else
            {
                colorCount = 1;
            }    
            return colorCount;
        }

        public static int Decrement()
        {
            if (colorCount > 1)
            {
                colorCount--;
            }
            else
            {
                colorCount = 3;
            }

            return colorCount;
        }
    }
}
