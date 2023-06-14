using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class ExpenseCRUD 
    {
        public static List<Expense> expenseList = new List<Expense>();
        public static void AddInList(Expense e)
        {
            expenseList.Add(e);
        }

        public static void RemoveFromList(int i)
        {
            expenseList.RemoveAt(i - 1);
        }


        public static void StoreExpensesInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Expense i in expenseList)
            {
                file.WriteLine(i.GetBillName() + "," + i.GetAmount() + "," + i.GetTax() + "," + i.GetType());
            }
            file.Flush();
            file.Close();
        }

        public static void LoadExpensesFromFile(string path)
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

                    Expense e = new Expense(name, amount, tax, type);
                    FinancialRecord f = new FinancialRecord(name, amount, type);
                    FinancialRecordCRUD.AddInList(f);
                    AddInList(e);

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
    }
}
