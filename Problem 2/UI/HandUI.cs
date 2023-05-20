using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.UI
{
    class HandUI
    {
        public static void PrintAverage(double average)
        {
            Console.WriteLine("Your average score is: " + average);
        }
        public static void PrintResult(bool flag)
        {
            if(flag)
            {
                Console.WriteLine("You won");

            }
            else
            {
                Console.WriteLine("You lost");
            }
        }
        public static string Option()
        {
            string option;
            Console.WriteLine("Predict next card High or low");
            option = Console.ReadLine();
            return option;
        }
    }
}
