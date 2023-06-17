using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Application.UI
{
    class ValidationsUI
    {
 
        public static void InvalidMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\tInvalid !!");
            Console.ResetColor();
            Console.Write("\tEnter again:");
        }
    }
}
