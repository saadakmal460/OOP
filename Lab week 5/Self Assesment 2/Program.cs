using Self_Assesment_2.BL;
using Self_Assesment_2.DL;
using Self_Assesment_2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                option = StudentUI.Menu();
                if(option == 1)
                {
                    Console.Clear();
                    Student s = StudentUI.takeInputForStudent();
                    StudentCRUD.AddInStudentList(s);
                }
                else if(option == 2)
                {
                    Console.Clear();
                    DegreeProgram d = DegreeProgramUI.TakeInputForDegree();
                    DegreeProgramCRUD.AddInDegreeProgram(d);
                   

                }
                else if(option == 3)
                {
                    Console.Clear();
                    List<Student> ss = new List<Student>();
                    ss = StudentCRUD.sortedMeritList();
                    StudentCRUD.giveAdmission(ss);
                    StudentCRUD.PrintStudents();
                }
                else if(option == 4)
                {
                    Console.Clear();
                    StudentUI.ViewAllStudents();
                }

                else if(option == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Enter degree name: ");
                    string name = Console.ReadLine();
                    StudentUI.ViewSpecificStudent(name);
                }
                else if(option == 6)
                {
                    Console.Clear();
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Student s = Student.StudentPresent(name);

                    if(s != null)
                    {
                        SubjectUI.ViewSubjects();
                        StudentUI.registerSubject(s);
                    }
                }
                else if(option == 7)
                {
                    Console.Clear();
                    StudentUI.FeeForStudents();

                }


            } while (option != 8);

        }
    }
}
