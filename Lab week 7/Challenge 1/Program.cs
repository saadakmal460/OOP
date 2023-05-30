using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DayScholer d = new DayScholer();
            Hostelite h = new Hostelite();

            d.name = "Saad";
            d.busNo = 12;

            h.name = "Ahmad";
            h.RoomNumber = 14;

            Console.WriteLine(d.name + " is allocated bus " + d.busNo);
            Console.WriteLine(h.name + " is allocated room number " + h.RoomNumber);

            Console.ReadKey();
        }
    }
}
