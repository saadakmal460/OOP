using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Revenue : FinancialRecord
    {
        private string extraChargesRevenue;
        public Revenue(string billName, string amount,string extraChargesRevenue , string type ) : base(billName, amount, type)
        {
            this.billName = billName;
            this.amount = amount;
            this.type = type;
            this.extraChargesRevenue = extraChargesRevenue;
        }

        public void SetExtraChargesRevenue(string r)
        {
            this.extraChargesRevenue = r;
        }

        public string GetExtraChargesRevenue()
        {
            return extraChargesRevenue;
        }
    }
}
