using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class NoticesCRUD
    {
        public static List<Notices> notices = new List<Notices>();
        public static void AddNoticesInList(Notices n)
        {
            notices.Add(n);
        }

        public static void RemoveANotice(int i)
        {
            notices.RemoveAt(i - 1);
        }
        public static void LoadNoticesFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string title = Parsing(record , 1);
                    string notices = Parsing(record, 2);
                    Notices n = new Notices(title, notices);
                    AddNoticesInList(n);
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
        public static void StoreNoticesInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Notices i in notices)
            {
                file.WriteLine(i.GetTitle() + "," + i.GetNotice());
            }
            file.Flush();
            file.Close();
        }
    }
}
