using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class BillsCRUD
    {
        public static List<Bills> billsList = new List<Bills>();

        public static void AddInList(Bills b)
        {
            billsList.Add(b);
        }

        public static void RemoveFromList(int i)
        {
            billsList.RemoveAt(i - 1);
        }

        public static void StoreBillsInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Bills i in billsList)
            {
                file.WriteLine(i.GetBillName()+ "," + i.GetAmount() + "," + i.GetBillType());
            }
            file.Flush();
            file.Close();
        }

        public static void LoadBillsFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {

                    string name = Parsing(record, 1);
                    string amount = Parsing(record, 2);
                    string type = Parsing(record, 3);
                    Bills b = new Bills(name, amount , type);
                    AddInList(b);

                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
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
