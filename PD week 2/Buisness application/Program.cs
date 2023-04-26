using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Credentials
    {
        public string name;
        public string password;

        public string sName;
        public string rollNo;
        public string cnic;
        public string city;


    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Credentials> user = new List<Credentials>();


            int option = 0;
            int option2 = 0;

            string name, password;
            do
            {
                Load(user);
                LoadStudents(user);
                
                
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    SignUp();
                    
                }
                else if (option == 2)
                {
                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    
                    if(LogIn(name, password, user))
                    {
                        do
                        {
                            Console.Clear();
                            option2 = Interface();
                            if (option2 == 1)
                            {
                                Console.Clear();
                                AddStudent(user);
                            }

                            else if(option2 == 2)
                            {
                                string sname;
                                Console.Write("Enter name of student: ");
                                sname = Console.ReadLine();
                                DeleteStudent(sname, user);
                            }
                            
                            else if(option2 == 3)
                            {
                                string student;
                                Console.Write("Enter name of student: ");
                                student = Console.ReadLine();
                                UpdateStudent(student, user);
                                
                            }

                            else if(option2 == 4)
                            {
                                Console.Clear();
                                ViewStudents(user);
                            }
                        } while (option2 != 5);
                        
                    }

                }

            } while (option != 3);


        }


        static void DeleteStudent(string name, List<Credentials> users)
        {
            bool removed = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].sName == name)
                {
                    users.RemoveAt(i);
                    DeleteFromFile(users);
                    removed = true;
                    break;
                }
            }
            
        }

        static void DeleteFromFile(List<Credentials> users)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < users.Count; i++)
            {
                file.WriteLine(users[i].sName + "," + users[i].rollNo + "," + users[i].cnic + "," + users[i].city);
            }
            file.Close();
        }


        static void UpdateInFile(List<Credentials> users)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\students.txt";
            
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < users.Count; i++)
            {
                
                Credentials user = users[i];
                file.WriteLine(user.sName + "," + user.rollNo + "," + user.cnic + "," + user.city);
            }
            file.Close();
        }



        static void UpdateStudent(string student, List<Credentials> users)
        {
            string stdRoll, stdCnic, stdCity;
            bool flag = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (student == users[i].sName)
                {
                    Console.Write("Enter roll no: ");
                    stdRoll = Console.ReadLine();

                    Console.Write("Enter cnic: ");
                    stdCnic = Console.ReadLine();

                    Console.Write("Enter city: ");
                    stdCity = Console.ReadLine();

                    users[i].rollNo = stdRoll;
                    users[i].cnic = stdCnic;
                    users[i].city = stdCity;

                    
                    UpdateInFile(users);

                    flag = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No record found");
            }
        }



        static void ViewStudents(List<Credentials> users)
        {
            Console.Write("Name\t\tRoll Number\t\tCNIC\t\tCity");
            for (int i = 0; i< users.Count; i++)
            {
                Console.WriteLine(users[i].sName + "\t\t" + users[i].rollNo + "\t\t\t" + users[i].cnic + "\t\t" + users[i].city);
               
            }
            Console.ReadKey();
        }
        static void LoadStudents(List<Credentials> users)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\students.txt";
            if (File.Exists(path))
            {
                
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    Credentials stu = new Credentials();
                    if (string.IsNullOrWhiteSpace(record))
                    {
                        continue;
                    }
                    stu.sName = Parsing(record, 1);
                    stu.rollNo = Parsing(record, 2);
                    stu.cnic = Parsing(record, 3);
                    stu.city = Parsing(record, 4);
                    
                    
                     users.Add(stu);
                    
                    
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

        static void AddFile(string name , string rollNumber , string cnic , string city)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + rollNumber + "," + cnic + "," + city);
            file.Flush();
            file.Close();
        }


        static void AddStudent(List<Credentials> user)
        {
            Credentials c = new Credentials();
            Console.Write("Enter name of student: ");
            c.sName = Console.ReadLine();

            Console.Write("Enter roll number of student: ");
            c.rollNo = Console.ReadLine();

            Console.Write("Enter CNIC of student: ");
            c.cnic = Console.ReadLine();

            Console.Write("Enter city: ");
            c.city = Console.ReadLine();
            AddFile(c.sName, c.rollNo, c.cnic, c.city);
            user.Add(c);

        }


        static bool LogIn(string name , string pass , List<Credentials> user)
        {
            bool flag = false;
            for(int i =0; i<user.Count;i++)
            {
                if(name == user[i].name && pass == user[i].password)
                {
                    flag = true;
                }
            }

            return flag;

            
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

        static void Load(List<Credentials> users)
        {
            
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\user.txt";
            

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    Credentials c2 = new Credentials();
                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);


                    c2.name = name;
                    c2.password = password;

                    users.Add(c2);
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }

           


        }

        static Credentials SignUp()
        {
            Credentials c = new Credentials();

            Console.Write("Enter username: ");
            c.name = Console.ReadLine();

            Console.Write("Enter password: ");
            c.password = Console.ReadLine();
            StoreData(c.name, c.password);
            return c;

        }


        static void StoreData(string name, string password)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 2\\Buisness application\\user.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }


        static int Interface()
        {
            int option;
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.Remove student");
            Console.WriteLine("3.Update record");
            Console.WriteLine("4.View students");
            Console.WriteLine("Enter option: ");

            option = int.Parse(Console.ReadLine());
            return option;
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Sign In");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
