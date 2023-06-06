using Problem_4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.UI
{
    class SquareUI
    {
        public Square takeInput()
        {
            double length;
            Console.WriteLine("Enter length: ");
            length = double.Parse(Console.ReadLine());

            Square s = new Square(length);
            return s;
        }
    }
}
