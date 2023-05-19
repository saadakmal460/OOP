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
            string path = "maze.txt";
            Grid g = new Grid(path, 24, 71);
            while (true)
            {
                g.Draw();
                Console.ReadKey();
            }
        }
    }
}
