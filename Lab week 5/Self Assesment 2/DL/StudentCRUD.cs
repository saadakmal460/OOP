using Self_Assesment_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.DL
{
    class StudentCRUD
    {
        public static List<Student> stu = new List<Student>();
        public static void AddInStudentList(Student s)
        {
            stu.Add(s);
        }
        public static List<Student> sortedMeritList()
        {
             List<Student> sortedList = new List<Student>();
            foreach(Student s in sortedList)
            {
                s.CalculateMerit();
            }
            sortedList = stu.OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }

        public static void giveAdmission(List<Student> sorted)
        {
            foreach(Student s in stu)
            {
                foreach(DegreeProgram d in s.prefrences)
                {
                    if(d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

        public static void PrintStudents()
        {
            foreach(Student s in stu)
            {
                if(s.regDegree !=null)
                {
                    Console.WriteLine(s.name + " got admisssion in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get admisssion");
                }
            }
            Console.ReadKey();
        }
    }
}
