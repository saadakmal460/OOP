using Problem_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.BL
{
    class Hand
    {
        public double CalculateAverage(int count , bool flag)
        {
            
            if (flag)
            {
                score +=5;
                Console.WriteLine(score);
            }
            else
            {
                score +=0;
                Console.WriteLine(score);
            }
            double average = score / count;
            return average;
            
        }
        public bool GetResult(Card c1 , Card c2 , string option)
        {
            bool flag = true;
            if (c2.value == 1 && option == "high")
            {
                flag = true;
            }
            else if (c1.value != 1 && c2.value > c1.value && option == "high")
            {
                flag = true;
            }
            else if (c1.value == 1 && c2.value == 1)
            {
                flag = true;
            }
            else if (c1.value != 1 && c2.value < c1.value && option == "low")
            {
                flag = true;
            }
            else if(c1.value == 1 && c2.value > c1.value && option == "low")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        public void SortByValue()
        {
            List<Card> sortByValue = new List<Card>();
            sortByValue = HandCRUD.cards.OrderBy(o => o.value).ToList();
        }
        public void SortBySuit()
        { 

            List<Card> sortBySuit = new List<Card>();
            sortBySuit = HandCRUD.cards.OrderBy(o => o.suit).ToList();
        }
        public Card GetCard(int position)
        {
            Card c = new Card(HandCRUD.cards[position].suit, HandCRUD.cards[position].value);
            return c;
        }
        public int GetCardCount()
        {
            return HandCRUD.cards.Count;
        }

        public double score;
       
    }
}
