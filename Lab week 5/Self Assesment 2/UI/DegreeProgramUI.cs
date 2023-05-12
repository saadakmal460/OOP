using Self_Assesment_2.BL;
using Self_Assesment_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.UI
{
    class DegreeProgramUI
    {

        public static DegreeProgram TakeInputForDegree()
        {
            Console.Write("Enter degree name: ");
            string name = Console.ReadLine();

            Console.Write("Enter duration: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter number of seats: ");
            int seats = int.Parse(Console.ReadLine());

            Console.Write("Enter number of subjects: ");
            int count = int.Parse(Console.ReadLine());

            for (int i=0; i< count; i++)
            {
                Subject s = SubjectUI.takeInputForSubjects();
                SubjectCRUD.AddSubjectsInList(s);
            }
            DegreeProgram dp = new DegreeProgram(name, time, seats);
            return dp;
        }

        public static void ViewDegreePrograms()
        {

            foreach(DegreeProgram s in DegreeProgramCRUD.dp)
            {
                Console.WriteLine(s.degreeName);

            }
        }
    }
}
