using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application
{
    class Program
    {
        class Studenets
        {
            public bool DeleteStudent(string name, List<Studenets> users)
            {
                bool removed = false;
                for (int i = 1; i < users.Count; i++)
                {
                    if (users[i].studentName == name)
                    {
                        users.RemoveAt(i);
                        DeleteFromFile(users);
                        removed = true;
                        
                        break;

                    }
                }

                if (!removed)
                {
                    Console.WriteLine("No record found");
                    
                }
                return removed;

            }
            public bool UpdateStudent(string student, List<Studenets> s)
            {
                string stdRoll, stdCnic, stdCity;
                bool flag = false;
                for (int i = 0; i < s.Count; i++)
                {
                    if (student == s[i].studentName)
                    {
                        Console.Write("Enter roll no: ");
                        stdRoll = Console.ReadLine();

                        Console.Write("Enter cnic: ");
                        stdCnic = Console.ReadLine();

                        Console.Write("Enter city: ");
                        stdCity = Console.ReadLine();

                        s[i].rollNumber = stdRoll;
                        s[i].cnic = stdCnic;
                        s[i].city = stdCity;

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
                return flag;
            }



            public void ViewStudenets(List<Studenets> s)
            {
                Console.Write("Name\t\tRoll Number\t\tCNIC\t\tCity");
                for (int i = 0; i < s.Count; i++)
                {
                    Console.WriteLine(s[i].studentName + "\t\t" + s[i].rollNumber + "\t\t\t" + s[i].cnic + "\t\t" + s[i].city);
                }
                Console.ReadKey();
            }

            public Studenets()
            {
                List<Studenets> data = new List<Studenets>(); 
            }
            public Studenets(string studentName , string rollNumber , string cnic ,  string city)
            {
                this.studentName = studentName;
                this.rollNumber = rollNumber;
                this.cnic = cnic;
                this.city = city;
            }
            public Studenets(string name , string password)
            {
                this.name = name;
                this.password = password;
            }
             
            public string name;
            public string password;

            public string studentName;
            public string rollNumber;
            public string cnic;
            public string city;

        }
        static void Main(string[] args)
        {
            List < Studenets > s = new List<Studenets>();
            
            int option = 0;
            int option2 = 0;
            string name="", pass="",student;
            
            do
            {
                Load(s);
                LoadUser(s);
                Console.Clear();
                option = Menu();
                if(option == 1)
                {
                    Console.Clear();
                    InputSignUp(s ,name , pass);
                    
                }
                else if(option == 2)
                {
                    Console.Clear();
                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter password: ");
                    pass = Console.ReadLine();
                    if (LogIn(name, pass, s))
                    {
                        Console.WriteLine("Admin Menu");
                        Console.ReadKey();
                        do
                        {
                            Console.Clear();
                            option2 = AdminMenu();
                            if(option2 == 1)
                            {
                                Console.Clear();
                                AddStudents(s);
                            }

                            else if(option2 == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Enter name of student: ");
                                student = Console.ReadLine();
                                Studenets record = new Studenets();
                                bool flag = record.DeleteStudent(student, s);
                                if(flag)
                                {
                                    DeleteFromFile(s);
                                }

                            }

                            else if(option2 == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Enter name of student: ");
                                student = Console.ReadLine();
                                Studenets stu = new Studenets();
                                bool flag = stu.UpdateStudent(student, s);
                                if(flag)
                                {
                                    UpdateInFile(s);
                                }
                                
                            }
                            else if(option2 == 4)
                            {
                                Console.Clear();
                                Studenets stu = new Studenets();
                                stu.ViewStudenets(s);
                                

                            }
                            

                        } while (option2 != 5);
                    }
                }



            } while (option != 3);

        }


        static void DeleteFromFile(List<Studenets> users)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 1; i < users.Count; i++)
            {
                file.WriteLine(users[i].studentName + "," + users[i].rollNumber + "," + users[i].cnic + "," + users[i].city);
            }
            file.Close();
        }

 
        static void UpdateInFile(List<Studenets> s)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness Application\\students.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 1; i < s.Count; i++)
            {
                file.WriteLine(s[i].studentName + "," + s[i].rollNumber + "," + s[i].cnic + "," + s[i].city);
            }
            file.Flush();
            file.Close();
        }

        static void LoadUser(List<Studenets> s)
        {
            string sName, rollNo, cnic, city;
            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness application\\students.txt";
            if (File.Exists(path))
            {

                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                   
                   
                    sName = Parsing(record, 1);
                    rollNo = Parsing(record, 2);
                    cnic = Parsing(record, 3);
                    city = Parsing(record, 4);
                    Studenets stu = new Studenets(sName, rollNo, cnic, city);

                    s.Add(stu);


                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
        static void StoreUser(string sName, string rollNo, string cnic,string  city)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness Application\\students.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(sName + "," + rollNo + "," + cnic + "," + city);
            file.Flush();
            file.Close();
        }

        static void AddStudents(List<Studenets> s)
        {
            string sName, rollNo, cnic, city;
            Console.Write("Enter name of student: ");
            sName = Console.ReadLine();

            Console.Write("Enter roll number of student: ");
            rollNo = Console.ReadLine();

            Console.Write("Enter CNIC of student: ");
            cnic = Console.ReadLine();

            Console.Write("Enter city: ");
            city = Console.ReadLine();

            StoreUser(sName, rollNo, cnic, city);
            Studenets data = new Studenets(sName, rollNo, cnic, city);
            s.Add(data);
            

        }
        static bool LogIn(String name , string pass , List<Studenets> s)
        {
            bool flag = false;
            for(int i=0;i<s.Count;i++)
            {
                if(name == s[i].name && pass == s[i].password)
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

        static void Load(List<Studenets> s)
        {

            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness Application\\user.txt";


            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string name = Parsing(record, 1);
                    string password = Parsing(record, 2);

                    Studenets data = new Studenets(name, password);
                    s.Add(data);
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }

        static int AdminMenu()
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
        static void InputSignUp(List<Studenets> s , string name , string pass)
        {
            
            Console.Write("Enter username: ");
            name = Console.ReadLine();

            Console.Write("Enter password: ");
            pass = Console.ReadLine();

            StoreData(name, pass);
            Studenets data = new Studenets(name, pass);
            s.Add(data);
           
        }

        static void StoreData(string name , string pass)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 3\\Buisness Application\\user.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + pass);
            file.Flush();
            file.Close();
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
