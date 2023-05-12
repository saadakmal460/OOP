using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.BL
{
    class DegreeProgram
    {
        
        public DegreeProgram(string degreeName , int duration , int seats)
        {
            this.degreeName = degreeName;
            this.duration = duration;
            this.seats = seats;
            s = new List<Subject>();
        }
        public string degreeName;
        public int duration;
        public List<Subject> s = new List<Subject>();
        public int seats;
    }
}
