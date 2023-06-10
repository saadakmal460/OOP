using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class HosteliteCRUD
    {
        public static List<Hostelite> hostelitesList = new List<Hostelite>();
        public static List<Hostelite> sortedList = new List<Hostelite>();


        public static void sortList()
        {
            sortedList = hostelitesList.OrderBy(o => o.GetRollNumber()).ToList();
        }
        public static void AddHosteliteInList(Hostelite h)
        {
            hostelitesList.Add(h);
        }

        public static bool RemoveFromHosteliteList(string name)
        {
           bool flag = false;
           for(int i = 0; i<hostelitesList.Count; i++)
           {
                if(name == hostelitesList[i].GetUsername())
                {
                    hostelitesList.RemoveAt(i);
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
           }
            return flag;
        }
        public static void StoreInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Hostelite i in hostelitesList)
            {
                file.WriteLine(i.GetUsername() + "," + i.GetRollNumber() + "," + i.GetCnic() + "," + i.GetCity() + "," + i.GetPassword() + "," + i.returnRole());
            }
            file.Flush();
            file.Close();
        }
        public static void DeleteHosteliteFromFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Hostelite i in hostelitesList)
            {
                file.WriteLine(i.GetUsername() + "," + i.GetRollNumber() + "," + i.GetCnic() + "," + i.GetCity() + "," + i.GetPassword() + "," + i.returnRole());
            }
            file.Flush();
            file.Close();
        }
        public static void LoadHostelitesFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string rollNumber = Parsing(record, 2);
                    string cnic = Parsing(record, 3);
                    string city = Parsing(record, 4);
                    string password = Parsing(record, 5);
                    string role = Parsing(record, 6);
                    Hostelite h = new Hostelite(name, cnic, city, rollNumber, password, role);
                    AddHosteliteInList(h);
                    UserCRUD.AdddInList(h);
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
