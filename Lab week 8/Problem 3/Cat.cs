using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Cat : Mamal
    {
            
        public Cat(string name) : base(name)
        {
            this.name = name;
        }

        public override void greet()
        {
            Console.WriteLine("Meow");
        }

        public override string toString()
        {
            return "Cat: Cat[ " + base.toString() + " ]";
        }
    }
}
