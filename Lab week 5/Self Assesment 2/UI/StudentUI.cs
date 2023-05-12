using Self_Assesment_2.BL;
using Self_Assesment_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.UI
{
    class StudentUI
    {
        public static void FeeForStudents()
        {
            foreach(Student s in StudentCRUD.stu)
            {
                Console.WriteLine(s.name + " has fee " + s.calculateFee());
            }
            Console.ReadKey();
        }

        public static void registerSubject(Student s)
        {
            Console.Write("How many subjects to register: ");
            int count = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter subject code: ");
                string code = Console.ReadLine();

                for (int j = 0; j < SubjectCRUD.sub.Count; j++)
                {
                    if(code == SubjectCRUD.sub[j].subjectCode)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        Console.Write("Not found");
                    }

                }

            }
            Console.ReadKey();
        }
        public static Student takeInputForStudent()
        {
            string name;
            int age;
            double fscMarks, ecatMarks;


            List<DegreeProgram> prefrences = new List<DegreeProgram>();

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Fsc Marks: ");
            fscMarks = double.Parse(Console.ReadLine());

            Console.Write("Enter Ecat Marks: ");
            ecatMarks = double.Parse(Console.ReadLine());

            DegreeProgramUI.ViewDegreePrograms();
            Console.Write("How many prefrences you want to enter: ");
            int count = int.Parse(Console.ReadLine());

            for(int i=0; i<count; i++)
            {
               
                bool flag = false;
                Console.Write("Enter degree name :");
                string dname = Console.ReadLine();

                foreach(DegreeProgram  s in DegreeProgramCRUD.dp)
                {
                    if(dname == s.degreeName)
                    {
                        flag = true;
                        prefrences.Add(s);
                        
                    }
                }

                if(!flag)
                {
                    Console.Write("No program exist");
                    i--;
                }
            }

            Student stu = new Student(name, age, fscMarks, ecatMarks, prefrences);
            return stu;

        }

        public static void ViewSpecificStudent(string degreeName)
        {
           
            Console.WriteLine("Name \t\tAge \t\t\tFsc Marks \t\t\tEcat Marks");
            foreach(Student i in StudentCRUD.stu)
            {
                foreach(DegreeProgram j in DegreeProgramCRUD.dp)
                {
                    if (degreeName == j.degreeName)
                    {
                        Console.WriteLine(i.name + "\t\t" + i.age + "\t\t\t" + i.fscMarks + "\t\t\t" + i.ecatMarks);
                    }
                }
                
            }

            Console.ReadKey();

        }


        public static void ViewAllStudents()
        {
            Console.WriteLine("Name \t\t Age \t\t\t Fsc Marks \t\t\t Ecat Marks");
            foreach(Student i in StudentCRUD.stu )
            {
                Console.WriteLine(i.name + "\t\t" + i.age + "\t\t\t" + i.fscMarks + "\t\t\t" + i.ecatMarks);
            }
            Console.ReadKey();
        }

        public static int Menu()
        {
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.Add degree program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View registered students");
            Console.WriteLine("5.View students of specifc program ");
            Console.WriteLine("6.Register subject for specific student");
            Console.WriteLine("7.Calculate fee");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
