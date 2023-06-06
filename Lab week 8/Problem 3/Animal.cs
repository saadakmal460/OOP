using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void greet()
        {
            Console.WriteLine("");
        }

        public virtual string toString()
        {
            string info = "Animal: Animal[name = " + name + " ]";
            return info;
        }
    }
}
