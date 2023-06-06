using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Student : Person
    {
        protected string program;
        protected int year;
        protected double fee;

        public Student(string name, string address , string program , int year , double fee) : base(name , address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;

        }

        public void setProgram(string program)
        {
            this.program = program;
        }

        public string getProgram()
        {
            return program;
        }

        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }

        public double getFee()
        {
            return fee;
        }

        public override string toString()
        {
            string info = base.toString() + " Program: " + program + " Year: " + year + " fee: " + fee.ToString();
            return info;
        }
    }
}
