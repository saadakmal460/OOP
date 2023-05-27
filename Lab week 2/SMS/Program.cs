using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class Program
    {
        class students
        {
            public string name;
            public int rollNo;
            public float cgpa;
            public char hostelite;
            public string department;

        }
        static void Main(string[] args)
        {
            students[] s = new students[10];
            int option = 0;
            int count = 0;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {

                    s[count] = AddStudents();
                    count++;
                }
                else if (option == 2)
                {
                    Console.Clear();
                    ViewStudents(s, count);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    TopStudents(s, count);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            } while (option != 4);
        }




        static int Largest(students[] s, int index, int count)
        {
            int x = index;
            float largest = s[index].cgpa;
            for(int i = index; i<count; i++)
            {
                if(largest < s[i].cgpa)
                {
                    largest = s[i].cgpa;
                    x = i; 
                }
            }
            return x;
        }

        static void TopStudents(students[] s, int count)
        {
            if(count == 0)
            {
                Console.WriteLine("No record found");
            }
            else if(count == 1)
            {
                ViewStudents(s, 1);
            }
            else if(count == 2)
            {
                for(int i = 0; i<2; i++)
                {
                    int index = Largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 2);
            }
            else if(count == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    int index = Largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 3);
            }
        }
        static void ViewStudents(students[] s , int count)
        {
            for(int i = 0; i<count; i++)
            {
                Console.WriteLine("Name: {0}  Roll Number: {1}  CGPA:{2}  Department: {3}   Hostelite: {4}", s[i].name, s[i].rollNo, s[i].cgpa, s[i].department, s[i].hostelite);
            }
        }

        static students AddStudents()
        {
            Console.Clear();
            students s1 = new students();

            Console.Write("Enter name: ");
            s1.name = Console.ReadLine();

            Console.Write("Enter roll number: ");
            s1.rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.Write("Enter department: ");
            s1.department = Console.ReadLine();

            Console.Write("IS hostelite 'y' || 'n': ");
            s1.hostelite = char.Parse(Console.ReadLine());

            return s1;
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.Add a studnet");
            Console.WriteLine("2.View studnets");
            Console.WriteLine("3.View top studnets");
            Console.WriteLine("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
