using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class ChallanDL
    {

        public static bool CheckInChallanList(string rollNumber)
        {
            bool flag2 = false;
            foreach (Challan i in Finance.GetChallanList())
            {
                if (rollNumber == i.GetRollNumber())
                {
                    flag2 = true;
                    break;
                }
            }
            return flag2;
        }
        public static void StoreChallansInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Challan i in Finance.GetChallanList())
            {
                file.WriteLine(i.GetRollNumber() + "," + i.GetChallanNumber() + "," + i.GetAmount() + "," + i.GetStatus());
            }
            file.Flush();
            file.Close();
        }

        public static void LoadChallansFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    
                    string rollNumber = Parsing(record, 1);
                    string challan = Parsing(record, 2);
                    string amount = Parsing(record, 3);
                    string status = Parsing(record, 4);
                    Challan c = new Challan(rollNumber, challan, amount , status);
                    Finance.AddChallanInList(c);

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
