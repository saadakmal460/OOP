using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static int userCount = 0;
        static void Main(string[] args)
        {
            int option = 0;
            int adminOption = 0;
            string name, password;
            string studentName = "", studentCnic = "", rollNumber = "", city = "";
            string removeStudent = "";
            string[] userName = new string[10];
            string[] pass = new string[10];
            string[] names = new string[10];
            string[] rollnumbers = new string[10];
            string[] cnics = new string[10];
            string[] cities = new string[10];
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Buisness application\\User.txt";

            Load(userName, pass, path);
            LoadStudents(names, rollnumbers, cnics, cities);
            while (option != 3)
            {
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter username: ");
                    password = Console.ReadLine();
                    bool flag = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (name == userName[i] && password == pass[i])
                        {
                            flag = true;
                            break;
                        }

                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Username password not found");
                    }
                    else if (flag == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Username password  found");
                        while (adminOption != 5)
                        {
                            Console.Clear();
                            adminOption = AdminMenu();
                            if (adminOption == 1)
                            {
                                Console.Clear();
                                Console.Write("Enter name: ");
                                studentName = Console.ReadLine();

                                Console.Write("Enter roll number: ");
                                rollNumber = Console.ReadLine();

                                Console.Write("Enter CNIC: ");
                                studentCnic = Console.ReadLine();

                                Console.Write("Enter city: ");
                                city = Console.ReadLine();


                                AddStudent(studentName, rollNumber, studentCnic, city, names, rollnumbers, cnics, cities);
                                Store(studentName, rollNumber, studentCnic, city);
                                Console.ReadKey();

                            }
                            else if (adminOption == 3)
                            {
                                Console.Clear();
                                UpdateStudent(names, rollnumbers, cnics, cities);
                                UpdateInFile(names, rollnumbers, cnics, cities);
                                Console.ReadKey();

                            }
                            else if (adminOption == 2)
                            {
                                Console.Clear();
                                Console.Write("Enter name of student: ");
                                removeStudent = Console.ReadLine();
                                RemoveStudent(removeStudent, names, rollnumbers, cnics, cities);
                                Console.WriteLine("Record deleted sucessfully");
                                Console.ReadKey();
                            }
                            else if (adminOption == 4)
                            {
                                Console.Clear();
                                ViewStudents(names, rollnumbers, cnics, cities);
                                Console.ReadKey();
                            }
                            Console.Clear();
                        }

                    }



                }
                if (option == 2)
                {

                    Console.Write("Enter username: ");
                    name = Console.ReadLine();

                    Console.Write("Enter username: ");
                    password = Console.ReadLine();

                    SignUp(path, name, password);
                    Console.Clear();

                }
            }
            Console.ReadKey();
        }

        static int Menu()
        {
            int option = 0;
            Console.WriteLine("\t1.SignIn");
            Console.WriteLine("\t2.SignUp");
            Console.WriteLine("\t3.Exit");
            Console.WriteLine("\tEnter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void SignUp(string path, string name, string password)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();

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

        static void Load(string[] name, string[] pass, string path)
        {
            int i = 0;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    name[i] = Parsing(record, 1);
                    pass[i] = Parsing(record, 2);
                    i++;
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
            int option = 0;
            Console.WriteLine("\t1.Add student");
            Console.WriteLine("\t2.Delete student");
            Console.WriteLine("\t3.Update record");
            Console.WriteLine("\t4.View students");
            Console.WriteLine("\t5.Exit");
            Console.WriteLine("\tEnter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void AddStudent(string name, string rollNumber, string cnic, string city, string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {


            names[userCount] = name;


            rollnumbers[userCount] = rollNumber;


            cnics[userCount] = cnic;


            cities[userCount] = city;

            userCount++;



        }

        static void Store(string name, string rollNumber, string cnic, string city)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + rollNumber + "," + cnic + "," + city);
            file.Flush();
            file.Close();

        }

        static string ParsingData(string record, int field)
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
                    item = item + record;
                }
            }
            return item;
        }

        static void LoadStudents(string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Buisness application\\students.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    names[userCount] = Parsing(record, 1);
                    rollnumbers[userCount] = Parsing(record, 2);
                    cnics[userCount] = Parsing(record, 3);
                    cities[userCount] = Parsing(record, 4);
                    userCount++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }

        static void ViewStudents(string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            Console.WriteLine("Name" + "\t" + "Roll Number" + "\t" + "CNIC" + "\t" + "City");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(names[i] + "\t" + rollnumbers[i] + "\t\t" + cnics[i] + "\t\t" + cities[i]);
            }
        }

        static void RemoveStudent(string name, string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            int j = 0;
            for (int i = 0; i < userCount; i++)
            {
                if (name == names[i])
                {
                    continue;
                }
                names[j] = names[i];
                cnics[j] = cnics[i];
                rollnumbers[j] = rollnumbers[i];
                cities[j] = cities[i];
                j++;
                DeleteFromFile(i, names, cnics, rollnumbers, cities);
            }
            userCount = j;

        }

        static void DeleteFromFile(int index, string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < userCount; i++)
            {
                if (i != index)
                {
                    file.WriteLine(names[i] + "," + rollnumbers[i] + "," + cnics[i] + "," + cities[i]);
                }
            }
            file.Close();

            for (int i = index; i < userCount - 1; i++)
            {
                names[i] = names[i + 1];
                rollnumbers[i] = rollnumbers[i + 1];
                cnics[i] = cnics[i + 1];
                cities[i] = cities[i + 1];
            }

            userCount--;
        }
        static void UpdateStudent(string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            string student, stdRoll, stdCnic, stdCity;
            bool flag = false;
            Console.Write("Enter name of student: ");
            student = Console.ReadLine();
            for (int i = 0; i <= userCount; i++)
            {
                if (student == names[i])
                {
                    flag = true;
                    Console.Write("Enter roll no: ");
                    stdRoll = Console.ReadLine();


                    Console.Write("Enter cnic: ");

                    stdCnic = Console.ReadLine();

                    Console.Write("Enter city: ");

                    stdCity = Console.ReadLine();

                    rollnumbers[i] = stdRoll;
                    cnics[i] = stdCnic;
                    cities[i] = stdCity;

                    break;
                }

                else
                {
                    continue;
                }

                if (flag == false)
                {
                    Console.Write("No record found");
                }
            }

        }
        static void UpdateInFile(string[] names, string[] rollnumbers, string[] cnics, string[] cities)
        {
            string path = "D:\\2nd Semester\\OOP\\PD week 1\\Buisness application\\students.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < userCount; i++)
            {
                file.WriteLine(names[i] + "," + rollnumbers[i] + "," + cnics[i] + "," + cities[i]);
            }
            file.Close();
        }
    }
}
