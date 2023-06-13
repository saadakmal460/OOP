using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.BL;

namespace Task_1.DL
{
    class MUserCRUD
    {
        private static List<MUser> users = new List<MUser>();

        public static void AddInList(MUser u)
        {
            users.Add(u);
        }

        public static bool SignIN(MUser user)
        {
            bool flag = true;
            foreach(MUser i in users)
            {
                if(user.GetName() == i.GetName() && user.GetPassword() == i.GetPassword())
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public static void StoreInFile(MUser i , string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            file.WriteLine(i.GetName() + "," + i.GetPassword() + "," + i.GetRole());
            
            file.Flush();
            file.Close();
        }
        public static bool LoadFromFile(string path)
        {
            bool flag;
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);
                    string role = Parsing(record, 3);
                    MUser u = new MUser(name, password, role);
                    
                }

                file.Close();
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
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
