using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Expense : FinancialRecord
    {
        private string tax;

        public Expense(string billName, string amount , string tax , string type) : base(billName , amount , type)
        {
            this.billName = billName;
            this.amount = amount;
            this.type = type;
            this.tax = tax;
        }

        public void SetTax(string tax)
        {
            this.tax = tax;
        }

        public string GetTax()
        {
            return tax;
        }

    }
}
