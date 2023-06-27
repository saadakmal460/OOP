using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;

namespace Buisness_Application.DL
{
    class NoticesDL
    {

        public static void RemoveANotice(List<Notices> n, int i)
        {
            n.RemoveAt(i - 1);
        }
        public static void LoadNoticesFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string title = Parsing(record, 1);
                    string notices = Parsing(record, 2);
                    Notices n = new Notices(title, notices);
                    Admin.AddNotices(n);
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
            foreach (Notices i in Admin.GetNoticesList())
            {
                file.WriteLine(i.GetTitle() + "," + i.GetNotice());
            }
            file.Flush();
            file.Close();
        }
    }
}
