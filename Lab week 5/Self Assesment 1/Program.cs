using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> x = new List<float>() { 1.2F, 5.6F, 8.9F, 34.876F };
            List<string> name = new List<string>() { "saad", "ahmad", "dddf", "aa" };
            x.Sort();
            name.Sort();

            //Float list
            foreach(float i in x)
            {
                Console.WriteLine(i);
            }

            //String list
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
