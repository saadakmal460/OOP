using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(4.5, 5);
            Cylinder c3 = new Cylinder(6, 6);


            c1.setHeight(10);
            double volume = c2.getVloume();
            Console.WriteLine(volume);
            Console.ReadKey();
        }
    }
}
