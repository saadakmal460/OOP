using Buisness_Application.DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.BL
{
    class Hostelite : User
    {
        protected string city;
        protected string cnic;
        protected string rollNumber;
        
        public Hostelite(string name , string cnic , string city , string rollNumber , string password , string role) : base(name , password , role)
        {
            this.username = name;
            this.cnic = cnic;
            this.city = city;
            this.rollNumber = rollNumber;
            this.password = password;
            role = "hostelite";
        }

        public void SetCity(string city)
        {
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }

        public void SetCnic(string cnic)
        {
            this.cnic = cnic;
        }
        public string GetCnic()
        {
            return cnic;
        }

        public void SetRollNumber(string rollNumber)
        {
            this.rollNumber = rollNumber;
        }
        public string GetRollNumber()
        {
            return rollNumber;
        }

        public void StoreInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            
            file.WriteLine(username + "," + rollNumber + "," + cnic + "," + city + "," + password + "," + role);
            
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
                    HosteliteCRUD.AddHosteliteInList(h);
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
