using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class PayFee
    {
        private string bank;
        private string accountNo;
        private string challanNumber;
        private string amount;

        public PayFee(string bank , string accountNo , string challanNumber , string amount)
        {
            this.bank = bank;
            this.amount = amount;
            this.accountNo = accountNo;
            this.challanNumber = challanNumber;
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

        public void SetBank(string bank)
        {
            this.bank = bank;
        }
        public string GetBank()
        {
            return bank;
        }

        public void SetAccountNo(string accountNo)
        {
            this.accountNo = accountNo;
        }
        public string GetAccountNo()
        {
            return accountNo;
        }


    }
}
