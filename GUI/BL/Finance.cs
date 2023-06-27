using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Finance : User
    {
        private string employeeNumber;
        private static List<Challan> challanList = new List<Challan>();
        private static List<FinancialRecord> recordList = new List<FinancialRecord>();
        public Finance(string username, string password , string role , string employeeNumber) : base(username, password, role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.employeeNumber = employeeNumber;
        }
        public void SetEmployeeNumber(string en)
        {
            employeeNumber = en;
        }

        public string GetEmployeeNumber()
        {
            return employeeNumber;
        }

        public static void AddChallanInList(Challan c)
        {
            challanList.Add(c);
        }

        public static List<Challan> GetChallanList()
        {
            return challanList;
        }

        public static void AddInList(FinancialRecord fr)
        {
            recordList.Add(fr);
        }

        public static List<FinancialRecord> GetFinancialRecordList()
        {
            return recordList;
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine("Employee number: " + employeeNumber);
        }

    }
}
