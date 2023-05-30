using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class DayScholer : Student
    {
        public string pickUpPoint;
        public int busNo;
        public int pickUpDistance;

        public int GetBusFee()
        {
            int fee = 0;
            fee = fee + 5000;
            return fee;
        }
    }
}
