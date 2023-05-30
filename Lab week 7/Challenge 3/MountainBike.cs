using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class MountainBike : Bicycle
    {
        public void SetSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
        public MountainBike(int seatHeight , int speed , int cadence , int gear)
        {
            this.seatHeight = seatHeight;
            this.speed = speed;
            this.cadence = cadence;
            this.gear = gear;
        }
        public int seatHeight;

    }
}
