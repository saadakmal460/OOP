using Problem_4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.UI
{
    class CircleUI
    {
        public Circle takeInput()
        {
            double radius;
            Console.WriteLine("Enter radius: ");
            radius = double.Parse(Console.ReadLine());

            Circle c = new Circle(radius);
            return c;
        }
    }
}
