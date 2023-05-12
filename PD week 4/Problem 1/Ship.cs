using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Ship
    {
        public string shipNumber;
        public string shipLattitude;
        public string shipLongitude;

        public Ship(string Number, string sl, string slog)
        {
            shipNumber = Number;
            shipLattitude = sl;
            shipLongitude = slog;
        }

    }
}
