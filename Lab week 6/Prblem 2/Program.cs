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
            char[,] Player = new char[,]
            {   {' ' , ' ' , 'o' , ' '},
                {' ' , '/' , '|' , '\\'},
                {' ' , ' ' , '|' , ' '},
                { ' ' , '/' , ' ' , '\\'}
            };

            Boundry b = new Boundry();
            GameObject o = new GameObject(Player, new Point(6, 0), b, "Projectile");
            while (true)
            {
                Thread.Sleep(1000);

                o.Remove();
                o.Move();
                o.Draw();
                
            }
           
        }
    }
}
