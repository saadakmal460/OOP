using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_application
{
    class Students
    {

        public Students(string studentName, string rollNumber, string cnic, string city)
        {
            this.studentName = studentName;
            this.rollNumber = rollNumber;
            this.cnic = cnic;
            this.city = city;
        }

        public string studentName;
        public string rollNumber;
        public string cnic;
        public string city;

        public List<Students> s = new List<Students>();

    }
}
