using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Dog : Mamal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }

        public override void greet()
        {
            Console.WriteLine("Whoof");
        }

        public void greets(Dog d)
        {
            Console.WriteLine("Whooooof");

        }

        public override string toString()
        {
            return "Dog: Dog[ " + base.toString() + " ]";

        }
    }
}
