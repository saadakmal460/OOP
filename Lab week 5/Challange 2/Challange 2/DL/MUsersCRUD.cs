using Challange_2.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.DL
{
    class MUsersCRUD
    {
        public static void AddUsersInList(MUsers m)
        {
            users.Add(m);
        }

        public static void AddUsersInFile(MUsers m)
        {
            string path = "Users.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(m.name + "," + m.password + "," + m.role);
            file.Flush();
            file.Close();
        }

        public static void LoadUsers()
        {
            string name,  pass , role;
            string path = "Users.txt";
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {


                    name = Parsing(record, 1);
                    pass = Parsing(record, 2);
                    role = Parsing(record, 3);

                    MUsers m = new MUsers(name, pass, role);

                    users.Add(m);


                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        static string Parsing(string record, int field)
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

        public static List<MUsers> users = new List<MUsers>();
    }
}
