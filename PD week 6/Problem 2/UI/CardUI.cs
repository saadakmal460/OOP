using Problem_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.UI
{
    class CardUI
    {
        public static void PrintCard(Card c1)
        {
            string card = c1.toString();
            Console.WriteLine(card);
        }
    }
}
