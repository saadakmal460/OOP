using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class Program
    {
        class Subject
        {
            public string subjectName;
            public string code;
            public int creditHours;
            public int fees;
            public Subject(string n, string c , int ch, int f)
            {
                subjectName = n;
                code = c;
                fees = f;
                creditHours = ch;
            }

        }
        class DegreeProgram
        {
            public string name;
            public int duration;
            public int seats;
            public DegreeProgram(string  n , int d , int s)
            {
                name = n;
                duration = d;
                seats = s;
            }

        }
        class Students
        {
            

            public double CalculateMerit()
            {
                double merit = fscMarks * 0.7 + ecatMarks * 0.3;
                return merit;
            }
            public Students(int fsc , int ecat)
            {
                fscMarks = fsc;
                ecatMarks = ecat;
            }
            public Students(string n , int mm , int fm , int em , List<string> s)
            {
                name = n;
                matricMarks = mm;
                fscMarks = fm;
                ecatMarks = em;
                prefrences = s;
            }
            public string name;
            public int matricMarks;
            public int fscMarks;
            public int ecatMarks;
            public List<string> prefrences = new List<string>();
            public List<Students> stu = new List<Students>();
            public List<DegreeProgram> d = new List<DegreeProgram>();
            public List<Subject> s = new List<Subject>();
            
        }
        static void Main(string[] args)
        {
            int option = 0;
            string dName;
            
            List<Students> stu = new List<Students>();
            List<DegreeProgram> d = new List<DegreeProgram>();
            List<Subject> s = new List<Subject>();
            do
            {
                Console.Clear();
                option = Menu();
                if(option == 1)
                {
                    Console.Clear();
                    AddStudent(d, stu);
                }
                if(option == 2)
                {
                    Console.Clear();
                    AddDegreeProgram(d, s);
                }
                if(option == 3)
                {

                }
                if(option == 4)
                {
                    Console.Clear();
                    viewStudents(stu);
                }
                if(option == 5)
                {
                    Console.Clear();
                    Console.Write("Enter degree name: ");
                    dName = Console.ReadLine();
                    SpecificStudents(dName, stu , d);
                }
                if(option == 6)
                {
                    Console.Clear();
                    Console.Write("Enter student name: ");
                    string Name = Console.ReadLine();

                    Console.Write("Enter subject code: ");
                    string code = Console.ReadLine();

                    bool flag = RegisterSubject(Name, code, stu, s);
                    if(flag)
                    {
                        Console.WriteLine("Subject registered sucessfully");
                    }
                    else
                    {
                        Console.WriteLine("Name or code is inncorrect");
                    }
                    Console.ReadKey();

                }

            } while (option != 8);
        }

        
        static bool RegisterSubject(string name , string code , List<Students> s, List<Subject> d)
        {
            bool flag = false;
            bool flag2 = false;
            for(int i=0; i<s.Count; i++)
            {
                if(name == s[i].name)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                for(int i=0; i<d.Count; i++)
                {
                    if(code == d[i].code)
                    {
                        flag2 = true;
                        break;
                    }
                }
            }

            return flag2;
        }
        static void SpecificStudents(string name , List<Students> s , List<DegreeProgram> d)
        {
            Console.WriteLine("Name" + "\t\t" + "Matric Marks" + "\t\t" + "Fsc Marks" + "\t\t" + "Ecat");
            for (int i = 0; i < s.Count; i++)
            {
                if (name == d[i].name)
                {
                    Console.WriteLine(s[i].name + "\t\t" + s[i].matricMarks + "\t\t\t" + s[i].fscMarks + "\t\t\t" + s[i].ecatMarks);
                }
            }
            Console.ReadKey();

        }
        static void viewStudents(List<Students> s)
        {
            Console.WriteLine("Name" + "\t\t" + "Matric Marks" + "\t\t" + "Fsc Marks" + "\t\t" + "Ecat");
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i].name + "\t\t" + s[i].matricMarks + "\t\t\t" + s[i].fscMarks + "\t\t" + s[i].ecatMarks);
            }
            Console.ReadKey();

        }
        static void AddDegreeProgram(List<DegreeProgram> d , List<Subject> s)
       {
            string degreename , subjectname , code;
            int duration, seats , credit , fee , subjects;

            Console.Write("Enter degree name: ");
            degreename = Console.ReadLine();
            Console.Write("Enter degree duration: ");
            duration = int.Parse(Console.ReadLine());
            Console.Write("Enter number of seats: ");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram info = new DegreeProgram(degreename , duration , seats);
            d.Add(info);

            Console.Write("Enter number of subjects: ");
            subjects = int.Parse(Console.ReadLine());

            for(int i =0;i<subjects;i++)
            {
                Console.Write("Enter subject code: ");
                code = Console.ReadLine();
                Console.Write("Enter subject name: ");
                subjectname = Console.ReadLine();

                Console.Write("Enter credit hours: ");
                credit = int.Parse(Console.ReadLine());

                Console.Write("Enter subject fee: ");
                fee = int.Parse(Console.ReadLine());

                Subject sub = new Subject(subjectname , code , credit , fee);
                s.Add(sub);
            }

       }
        static void AddStudent(List<DegreeProgram> d , List<Students> s)
        {
            string name , pref; 
            int matricMarks, fscMarks, ecatMarks , number;
            List<string> prefrences = new List<string>();
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter Matric Marks: ");
            matricMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Fsc Marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ecat marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Availaible degree programs....");
            for(int i=0; i<d.Count; i++)
            {
                Console.WriteLine(d[i].name);
            }
            Console.WriteLine("Enter how many prefrences: ");
            number = int.Parse(Console.ReadLine());
            for(int i=0; i<number;i++)
            {
                Console.Write("Enter prefrence: ");
                pref = Console.ReadLine();
                prefrences.Add(pref);
            }
            Students stu = new Students(name, matricMarks, fscMarks, ecatMarks, prefrences);
            s.Add(stu);
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View registered students");
            Console.WriteLine("5.Viw students of specific program");
            Console.WriteLine("6.Register subject for specific student");
            Console.WriteLine("7.Calculate fees");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter your option: ");

            option = int.Parse(Console.ReadLine());
            return option;
        
        }
    }
}
