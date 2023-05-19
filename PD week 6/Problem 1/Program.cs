using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid g = new Grid(path, 24, 71);
            g.Draw();
            Ghost gg = new Ghost(15, 39, "Left", 'R',  0.1F, ' ' , 1F, g);
            while (true)
            {
                Thread.Sleep(90);
                gg.Remove();
                gg.Move();
                gg.Draw();
                
            }
        }
    }
}
