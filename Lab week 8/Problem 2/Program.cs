using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Saad", "380 H1", "BS CS" , 4, 550000);
            Student s2 = new Student("Ahmad", "Shadra", "BS CS", 4, 550000);

            Staff st1 = new Staff("Saad", "380 H1", "KIPS", 1000000);
            Staff st2 = new Staff("Ahmad", "Shadra", "KIPS", 1000000);

            string info1 = s1.toString();
            string info2 = s2.toString();

            string info3 = st1.toString();
            string info4 = st2.toString();

            Console.WriteLine(info1);
            Console.WriteLine(info2);

            Console.WriteLine(info3);
            Console.WriteLine(info4);



            Console.ReadKey();

        }
    }
}
