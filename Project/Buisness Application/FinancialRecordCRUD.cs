using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class FinancialRecordCRUD
    {
        public static List<FinancialRecord> recordList = new List<FinancialRecord>();

        
        public static void AddInList(FinancialRecord fr)
        {
            recordList.Add(fr);
        }

        public static void RemoveFromList(int i)
        {
            recordList.RemoveAt(i - 1);
        }


        public static int CalculateDigits(string type)
        {
            int num = CalculateTotalAmount(type);
            int count = 0;
            while(num != 0)
            {
                num = num / 10;
                count++;
                
            }
            return count;
        }
        public static int CalculateTotalAmount(string type)
        {
            int sum = 0;
            foreach(FinancialRecord i in recordList)
            {
                if(type == i.GetType())
                {
                    sum = sum + int.Parse(i.GetAmount());
                }
            }
            return sum;
        }
    }
}
