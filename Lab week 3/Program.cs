using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_week_3
{
    class Program
    {
        class Student
        {
            
            public Student(string n , float m , float f , float e , float a)
            {
                name = n;
                matricMarks = m;
                fscMarks = f;
                ecatMarks = e;
                aggregate = a;
            }
            public Student()
            {
                //Console.WriteLine("This is default constructor");
                name = "saad";
                matricMarks = 1028F;
                fscMarks = 991F;
                ecatMarks = 153F;
                aggregate = 79.9F;
            }
            public string name;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;
        }
        static void Main(string[] args)
        {
            Task6();
            Console.ReadKey();

        }

        static void Task1()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }

        static void Task2()
        {
            Student s2 = new Student();
        }

        static void Task3()
        {
            Student s3 = new Student();
            Console.WriteLine(s3.name);
        }

        static void Task4()
        {
            Student s4 = new Student();
            Console.WriteLine(s4.name);
            Console.WriteLine(s4.matricMarks);
            Console.WriteLine(s4.fscMarks);
            Console.WriteLine(s4.ecatMarks);
            Console.WriteLine(s4.aggregate);
        }

        static void Task5()
        {
            Student s = new Student("Ahmad" , 33F , 991F , 153F , 79.9F);
            Student s1 = new Student("Saad",1028F, 991F, 153F, 79.9F);
            Console.WriteLine(s.name);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.WriteLine();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }

        static void Task6()
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }

        static void Task7()
        {

        }
    }
}
