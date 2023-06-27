using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class FinancialRecordDL
    {

        public static bool RemoveFromList(string name)
        {
            bool flag = false;
            for (int i =0; i<Finance.GetFinancialRecordList().Count; i++)
            {
                FinancialRecord record = Finance.GetFinancialRecordList()[i];
                if (name == record.GetBillName())
                {
                    if (record is Revenue)
                    {
                        Finance.GetFinancialRecordList().RemoveAt(i);
                        flag = true;
                    }
                    else if (record is Expense)
                    {
                        Finance.GetFinancialRecordList().RemoveAt(i);
                        flag = true;
                    }
                }
            }
            return flag;
        }
        public static void StoreInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (FinancialRecord i in Finance.GetFinancialRecordList())
            {
                if (i is Revenue)
                {
                    Revenue revenueRecord = (Revenue)i;
                    file.WriteLine(i.GetBillName() + "," + i.GetAmount() + "," + revenueRecord.GetExtraChargesRevenue() + "," + i.GetType());
                }
                else if(i is Expense)
                {
                    Expense expenseRecord = (Expense)i;
                    file.WriteLine(i.GetBillName() + "," + i.GetAmount() + "," + expenseRecord.GetTax() + "," + i.GetType());

                }
            }
            file.Flush();
            file.Close();
        }

        public static void LoadFinancialRecordFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {

                    string name = Parsing(record, 1);
                    string amount = Parsing(record, 2);
                    string tax = Parsing(record, 3);
                    string type = Parsing(record, 4);
                    if(type == "Expense")
                    {
                        Expense e = new Expense(name, amount, tax, type);
                        Finance.AddInList(e);
                    }
                    else if(type == "Revenue")
                    {
                        Revenue r = new Revenue(name, amount, tax, type);
                        Finance.AddInList(r);

                    }


                }

                file.Close();
            }
        }

        public static string Parsing(string record, int field)
        {
            int count = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    count++;
                }
                else if (count == field)
                {
                    item = item + record[i];
                }
            }
            return item;
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
            foreach(FinancialRecord i in Finance.GetFinancialRecordList())
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
