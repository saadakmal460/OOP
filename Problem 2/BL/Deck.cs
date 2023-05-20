using Problem_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.BL
{
    class Deck
    {

        public int Shuffle()
        {
            Random r = new Random();
            int value = r.Next(1, DeckCRUD.c.Count);
            return value;
        }
        
        public int CardsLeft()
        {
            return DeckCRUD.c.Count;
        }
        public Card DealCard()
        {

            int i = Shuffle();
            Card cd = new Card(DeckCRUD.c[i].suit, DeckCRUD.c[i].value);
            DeckCRUD.RemoveCard(i);
            return cd;


        }
        public Deck()
        {
            for(int i=1; i<5; i++)
            {
                for(int j=1; j<14;j++)
                {
                    int suit = i;
                    int value = j;
                    Card cd = new Card(suit, value);
                    DeckCRUD.AddCard(cd);
                }
            }
        }
        
    }
}
