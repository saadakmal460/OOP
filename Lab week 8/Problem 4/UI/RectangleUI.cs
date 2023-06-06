using Problem_4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.UI
{
    class RectangleUI
    {
        public Rectangle takeInput()
        {
            double length, width;
            Console.WriteLine("Enter length: ");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width = double.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(length, width);
            return r;
        }
    }
}
