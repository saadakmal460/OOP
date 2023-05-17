using Prblem_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prblem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject o = new GameObject();
            while (true)
            {
                Thread.Sleep(100);
                
                o.Move();
            }
            Console.ReadKey();
        }
    }
}
