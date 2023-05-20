using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.BL
{
    class Card
    {
        public string toString()
        {
            string card;
            card = getSuitAsString() + " of " + getValueAsString();
            return card;
        }
        public string getValueAsString()
        {
            string valueString;
            if (value == 11)
            {
                valueString = "Jack";
            }
            else if(value == 12)
            {
                valueString = "Queen";
            }
            else if(value == 13)
            {
                valueString = "King";
            }
            else if(value == 1)
            {
                valueString = "Ace";
            }
            else
            {
                valueString = value.ToString();
            }
            return valueString;
        }
        public string getSuitAsString()
        {
            string suitString = "";
            if (suit == 1)
            {
                suitString = "Clubs";
            }
            else if(suit == 2)
            {
                suitString = "Diamonds";
            }
            else if(suit == 3)
            {
                suitString = "Spades";
            }
            else if(suit == 4)
            {
                suitString = "Hearts";
            }
            return suitString;
        }
        public int getValue()
        {
            return value;
        }
        public int getSuit()
        {
            return suit;
        }
        public Card(int suit , int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public int value;
        public int suit;
        
       
    }
}
