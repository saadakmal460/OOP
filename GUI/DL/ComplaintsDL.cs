using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class ComplaintsDL
    {

        public static void StoreComplaintsInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Complaints i in Hostelite.GetComplaintsList())
            {
                file.WriteLine(i.GetName() + "," + i.GetComplaint());
            }
            file.Flush();
            file.Close();
        }
        public static void LoadComplaintsFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string complaints = Parsing(record, 2);
                    Complaints c = new Complaints(name, complaints);
                    Hostelite.AddComplaintsInList(c);
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
