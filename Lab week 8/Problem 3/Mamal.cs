using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Mamal : Animal
    {
        public Mamal(string name) : base(name)
        {
            this.name = name;
        }

        public override string toString()
        {
            return "Mamal: Mamal[ " + base.toString() + " ]";
        }
    }
}
