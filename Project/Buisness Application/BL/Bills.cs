using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Bills
    {
        private string billName;
        private string amount;
        private string billType;
        public Bills(string billName, string amount , string billType)
        {
            this.billName = billName;
            this.amount = amount;
            this.billType = billType;
        }

        public Bills()
        {

        }
        public void SetBillName(string billName)
        {
            this.billName = billName;
        }

        public string GetBillName()
        {
            return billName;
        }

        public void SetAmount(string amount)
        {
            this.amount = amount;
        }

        public string GetAmount()
        {
            return amount;
        }

        public void SetBillType(string billType)
        {
            this.billType = billType;
        }

        public string GetBillType()
        {
            return billType;
        }

        public int GetTotalAmount(int amount)
        {
            
            amount = amount + int.Parse(GetAmount());
            return amount;
        }

        public int GetAmountDigits(int amount)
        {
            int count = 0;
            while(amount != 0)
            {
                amount = amount / 10;
                count++;
            }
            return count;
        }
    }
}
