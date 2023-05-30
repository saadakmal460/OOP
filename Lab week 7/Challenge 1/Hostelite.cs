using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Hostelite : Student
    {
        public int RoomNumber;
        public bool isFridgeAvailable;
        public bool isInternetAvailable;

        public int getFees()
        {
            int fee = 0;
            fee = fee + 5000;
            return fee;
        }
    }
}
