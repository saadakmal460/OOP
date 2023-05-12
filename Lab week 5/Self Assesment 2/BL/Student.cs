using System;
using Self_Assesment_2.BL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Assesment_2.DL;

namespace Self_Assesment_2.BL
{
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> prefrences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        
        public float calculateFee()
        {
            float fee = 0;
            foreach (Subject s in SubjectCRUD.sub)
            {
                fee = fee + s.subjectFee;
            }

            return fee;
        }
        public static Student StudentPresent(string name)
        {
            
            foreach(Student s in StudentCRUD.stu)
            {
                if(name == s.name)
                {
                    return s;
                }
                
            }
            return null;
        }
        public void CalculateMerit()
        {
            this.merit = ((fscMarks * 0.4) + (ecatMarks * 0.6)) * 100;
        }
        public Student(string name , int age , double fscMarks , double ecatMarks , List<DegreeProgram> prefrences)
        {

            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.prefrences = prefrences;
            regSubject = new List<Subject>();

        }
    }
}
