using Self_Assesment_2.BL;
using Self_Assesment_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.UI
{
    class SubjectUI
    {
        public static void ViewSubjects()
        {
            foreach(Subject s in SubjectCRUD.sub)
            { 
                Console.WriteLine("Subject code: " + s.subjectCode);
            }
        }
        public static Subject takeInputForSubjects()
        {
            Console.Write("Enter subject code: ");
            string code = Console.ReadLine();

            Console.Write("Enter subject type: ");
            string type = Console.ReadLine();

            Console.Write("Enter credit hours :");
            int ch = int.Parse(Console.ReadLine());

            Console.Write("Enter fees:");
            int fees = int.Parse(Console.ReadLine());

            Subject s = new Subject(code, type, ch, fees);

            return s;

        }
    }
}
