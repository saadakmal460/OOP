using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class AdminCRUD
    {
        public static List<Admin> adminList = new List<Admin>();

        public static void AddInList(Admin a)
        {
            adminList.Add(a);
        }

        public static void StoreAdminInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Admin i in adminList)
            {
                file.WriteLine(i.GetUsername() + "," + i.GetPassword() + "," + i.GetContact() + "," + i.returnRole());
            }
            file.Flush();
            file.Close();
        }

        public static void LoadAdminFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {

                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);
                    string conatact = Parsing(record, 3);
                    string role = Parsing(record, 4);

                    Admin a = new Admin(name, password, conatact, role);
                    AddInList(a);
                    UserCRUD.AdddInList(a);
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
