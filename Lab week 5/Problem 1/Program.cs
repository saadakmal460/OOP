using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_week_5
{
    class Program
    {
        class Students
        {
            public float CalculateMerit()
            {
                float aggregate = ((fscMarks / 1100F) * 0.6F + (ecatMarks / 400F) * 0.4F) * 100F;
                return aggregate;
            }
            public bool Scholership(double aggregate, bool hostelite)
            {
                bool flag = false;
                if (aggregate > 80 && hostelite)
                {
                    flag = true;
                    isTakingScholership = flag;
                }
                return flag;
            }
            public Students(string n, int roll, float Gpa, int matric, int fsc, int ecat, string hT, bool Hostelite)
            {
                name = n;
                rollNumber = roll;
                cGpa = Gpa;
                matricMarks = matric;
                fscMarks = fsc;
                ecatMarks = ecat;
                homeTown = hT;
                isHostelite = Hostelite;
            }
            public string name;
            public int rollNumber;
            public float cGpa;
            public int matricMarks;
            public int fscMarks;
            public int ecatMarks;
            public string homeTown;
            public bool isHostelite;
            public bool isTakingScholership;

        }
        static void Main(string[] args)
        {
            Students s = new Students("Saad", 148, 3.4F, 1028, 991, 153, "Lahore", true);
            float percentage = s.CalculateMerit();
            Console.WriteLine("Aggregate is : " + percentage);
            bool flag = s.Scholership(percentage, true);
            Console.WriteLine("Taking scholership: " + flag);
            Console.ReadKey();

        }
    }
}
