using Self_Assesment_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_2.BL
{
    class Subject
    {

        
        public static bool checkCreditHours(Subject s)
        {
            int ch = Subject.getCreditHours();
            if(ch+s.creditHour <=9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int getCreditHours()
        {
            int count = 0;
            for(int i=0; i<SubjectCRUD.sub.Count;i++)
            {
                count = count + SubjectCRUD.sub[i].creditHour;
            }
            return count;

        }
        public Subject(string subjectCode , string subjectType , int creditHour , int subjectFee)
        {
            this.subjectCode = subjectCode;
            this.subjectType = subjectType;
            this.creditHour = creditHour;
            this.subjectFee = subjectFee;

        }
        public string subjectCode;
        public string subjectType;
        public int creditHour;
        public int subjectFee;
    }
}
