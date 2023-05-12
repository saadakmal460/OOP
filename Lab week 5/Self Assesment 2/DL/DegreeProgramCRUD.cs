using Self_Assesment_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.DL
{
    class DegreeProgramCRUD
    {
        public static List<DegreeProgram> dp = new List<DegreeProgram>();

        public static void AddInDegreeProgram(DegreeProgram d)
        {
            dp.Add(d);
        }
    }
}
