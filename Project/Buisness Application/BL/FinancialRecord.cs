using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class FinancialRecord
    {
        protected string billName;
        protected string amount;
        protected string type;
        public FinancialRecord(string billName, string amount, string type)
        {
            this.billName = billName;
            this.amount = amount;
            this.type = type;
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

        public void SetType(string type)
        {
            this.type = type;
        }

        public string GetType()
        {
            return type;
        }


    }
}
