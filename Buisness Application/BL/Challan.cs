using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Challan
    {
        private string rollNumber;
        private string challanNumber;
        private string amount;
        public Challan(string rollNumber , string challanNumber , string amount)
        {
            this.rollNumber = rollNumber;
            this.challanNumber = challanNumber;
            this.amount = amount;
        }


        public void SetRollNumber(string rollNumber)
        {
            this.rollNumber = rollNumber;
        }
        public string GetRollNumber()
        {
            return rollNumber;
        }

        public void SetChallanNumber(string challanNumber)
        {
            this.challanNumber = challanNumber;
        }
        public string GetChallanNumber()
        {
            return challanNumber;
        }

        public void SetAmount(string amount)
        {
            this.amount = amount;
        }
        public string GetAmount()
        {
            return amount;
        }

    }
}
