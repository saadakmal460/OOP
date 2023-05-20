using Problem_2.BL;
using Problem_2.DL;
using Problem_2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;
            char option2 = 'y';
            int count = 0;
            
            double average = 0;
            Deck d = new Deck();

            do
            {
                Console.Clear();
                option = Menu();

                if(option == 1)
                {
                    
                    //Dealing first card
                    Card c = d.DealCard();
                    Hand h = new Hand();
                    HandCRUD.AddCard(c);
                    Card c1 = new Card(c.suit, c.value);
                    while (option2 != 'n')
                    {
                        //printing card
                        Console.Clear();
                        CardUI.PrintCard(c1);

                        //Asking high or low
                        string cardOption = HandUI.Option();

                        //Dealing second card
                        Card c2 = d.DealCard();
                        HandCRUD.AddCard(c);
                        CardUI.PrintCard(c2);
                        

                        //Declearing results
                        bool flag = h.GetResult(c1 , c2 , cardOption);
                        HandUI.PrintResult(flag);

                        //calculating average
                        count++;
                        average = h.CalculateAverage(count , flag);
                        
                        //asking to play again
                        Console.WriteLine("Play again 'y' or 'n'");
                        option2 = char.Parse(Console.ReadLine());
                        
                        c1 = c2;
                        
                    }
                    
                    //printing average
                    HandUI.PrintAverage(average);
                    Console.ReadKey();
                    option2 = 'y';
                }

                else if(option == 2)
                {
                    //printing instructions
                    Console.WriteLine("Predict the next card");
                    Console.WriteLine("Get 5 points for each correct guess");
                    Console.WriteLine("Best OF Luck");
                    Console.ReadKey();
                }


            } while (option != 3);
            

            
            
        }

        static int Menu()
        {
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Instructions");
            Console.WriteLine("3.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

    }
}
