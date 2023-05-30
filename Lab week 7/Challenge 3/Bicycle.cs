using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Bicycle
    {
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void ApplyBreak(int decrement)
        {
            speed = speed - decrement;
        }
        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public Bicycle(int cadence , int gear , int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public int cadence;
        public int gear;
        public int speed;

    }
}
