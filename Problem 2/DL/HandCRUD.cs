using Problem_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.DL
{
    class HandCRUD
    {
        public static void RemoveCard(int position)
        {
            cards.RemoveAt(position);
        }
        public static void ClearAll()
        {
            cards.Clear();
        }
        public static void RemoveCard(Card c)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (c.value == cards[i].value && c.suit == cards[i].suit)
                {
                    cards.RemoveAt(i);
                }
            }
        }
        public static void AddCard(Card c)
        {
            cards.Add(c);
        }

        public static List<Card> cards = new List<Card>();
    }
}
