using Problem_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.DL
{
    class DeckCRUD
    {
        public static void RemoveCard(int i)
        {
            c.RemoveAt(i);
        }
        public static void AddCard(Card cd)
        {
            c.Add(cd);
        }
        public static List<Card> c = new List<Card>();
    }
}
