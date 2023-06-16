using Buisness_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.DL
{
    class UserCRUD
    {
        public static List<User> userList = new List<User>();

        public static void AdddInList(User user)
        {
            userList.Add(user);
        }

        public static List<User> SortedList()
        {
            foreach (User i in userList)
            {
                if (i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    userList = userList.OrderBy(o => h.GetRollNumber()).ToList();
                } 
        
            
            }
            return userList;
        }
        public static bool RemoveUserFromList(string name)
        {
            bool flag = false;
            for (int i = 0; i < userList.Count; i++)
            {
                User u = userList[i];
                if (name == u.GetUsername())
                {
                    if (u is Hostelite)
                    {
                        userList.RemoveAt(i);
                        flag = true;
                    }
                }
            }
            return flag;
        }
        public static void StoreUsersInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach(User i in userList)
            {
                if(i is Hostelite)
                {
                    Hostelite h = (Hostelite)i;
                    file.WriteLine(i.GetUsername() + "," + i.GetPassword() +  "," + i.returnRole() + "," + h.GetRollNumber()+ "," + h.GetCnic() + "," + h.GetCity() + "," + h.GetRoomNumber());
                }
                if(i is Admin)
                {
                    Admin a = (Admin)i;
                    file.WriteLine(i.GetUsername() + "," + i.GetPassword() + "," + i.returnRole() + "," + a.GetContact());
                }
            }
            file.Flush();
            file.Close();
        }

        public static void LoadUsersFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);
                    string role = Parsing(record, 3);
                    string rollNumber = Parsing(record, 4);

                    if (role == "hostelite")
                    {
                        
                        string cnic = Parsing(record, 5);
                        string city = Parsing(record, 6);
                        string roomNumber = Parsing(record, 7);
                        Hostelite h = new Hostelite(name, cnic, city, rollNumber, password, role, roomNumber);
                        AdddInList(h);
                    }
                    else if(role == "admin")
                    {
                        Admin a = new Admin(name, password, rollNumber, role);
                        AdddInList(a);
                    }

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
