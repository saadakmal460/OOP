using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Angle
    {
        public int degree;
        public float minutes;
        public char direction;

        public Angle(int deg, float m, char direc)
        {
            degree = deg;
            minutes = m;
            direction = direc;
        }
    }
}
