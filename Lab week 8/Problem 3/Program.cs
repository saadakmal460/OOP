using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> a = new List<Animal>();
            Cat c = new Cat("coco");
            Dog d = new Dog("Husky");
            Cat c1 = new Cat("cat");
            Dog d1 = new Dog("Rotviler");
            a.Add(c);
            a.Add(c1);
            a.Add(d);
            a.Add(d1);
            foreach(Animal i in a)
            {
                i.greet();
                Console.WriteLine(i.toString());
            
            }

            Console.ReadKey();
        }
    }
}
