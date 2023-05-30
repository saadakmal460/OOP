using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Student
    {
        public string name;
        public string session;
        public bool isHostelite;
        public int EcatMarks;
        public int HSMarks;

        public double CalculateMerit()
        {
            double merit = 0;
            merit = (EcatMarks / 400) * 100;
            return merit;
        }
    }
}
