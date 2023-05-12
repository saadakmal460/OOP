using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1b
{
    class Student
    {
        public Student(string n , int rollNo , string c , int m)
        {
            name = n;
            rollNumber = rollNo;
            city = c;
            marks = m;
        }
        public string name;
        public int rollNumber;
        public string city;
        public int marks;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Saad", 148, "Lahore", 991);
            Student s2 = new Student("a", 111, "Lahore", 1000);

            List<Student> s = new List<Student>() { s1, s2 };
            List<Student> sorted = s.OrderByDescending(o => o.rollNumber).ToList();

            foreach(Student i in sorted)
            {
                Console.WriteLine(i.name + "\t\t" + i.rollNumber + "\t\t" + i.city + "\t\t" +  i.marks);
            }

            Console.ReadKey();
        }
    }
}
