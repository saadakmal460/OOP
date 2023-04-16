using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_week_2
{
    class Program
    {
        class Students
        {
            public string name;
            public int rollNo;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            Task3();
            Console.ReadKey();
        }

        static void Task1()
        {
            Students s1 = new Students();

            s1.name = "Ahmad";
            s1.rollNo = 144;
            s1.cgpa = 3.9F;
            Console.WriteLine("Name:{0} , Roll number:{1} , CGPA:{2} ", s1.name, s1.rollNo, s1.cgpa);
        }

        static void Task2()
        {
            Students s1 = new Students();
            Students s2 = new Students();

            s1.name = "Ahmad";
            s1.rollNo = 144;
            s1.cgpa = 3.9F;
            Console.WriteLine("Name:{0} , Roll number:{1} , CGPA:{2} ", s1.name, s1.rollNo, s1.cgpa);

            

            s2.name = "Saad";
            s2.rollNo = 148;
            s2.cgpa = 3.6F;
            Console.WriteLine("Name:{0} , Roll number:{1} , CGPA:{2} ", s2.name, s2.rollNo, s2.cgpa);
        }

        static void Task3()
        {
            Students s1 = new Students();
            Console.Write("Enter name: ");
            s1.name = Console.ReadLine();

            Console.Write("Enter roll number: ");
            s1.rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Name:{0} , Roll number:{1} , CGPA:{2} ", s1.name, s1.rollNo, s1.cgpa);
        }
    }
}
