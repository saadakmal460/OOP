using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {

        static void Main(string[] args)
        {
            List < Ship > s = new List<Ship>();
            int option = 0;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    Ship sh = addShip();
                    AddToList(sh, s);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.Write("Enter ship number: ");
                    string number = Console.ReadLine();

                    SearchShip(s, number);

                }

                else if (option == 3)
                {
                    Console.Clear();
                    Console.Write("Enter ship lattittude: ");
                    string lat = Console.ReadLine();
                    Console.Write("Enter ship longitude: ");
                    string log = Console.ReadLine();
                    SearchNumber(lat, log, s);
                }

                else if(option == 4)
                {
                    Console.Write("Enter ship number: ");
                    string number = Console.ReadLine();
                    changePosition(s, number);

                }



            } while (option != 5);


        }

        static void changePosition(List<Ship> s , string number)
        {
            bool flag = false;
            foreach (Ship x in s)
            {
                if(x.shipNumber == number)
                {
                    flag = true;
                    int degree1, degree2;
                    float minutes1, minutes2;
                    char direction1, direction2;

                    string slattitude, slongitude;
                   
                    Console.WriteLine("Enter ship lattitude: ");
                    Console.Write("Enter degree: ");
                    degree1 = int.Parse(Console.ReadLine());
                    while (degree1 > 90)
                    {
                        Console.Write("Latittude must be less than 90 degrees: ");
                        degree1 = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter minutes: ");
                    minutes1 = float.Parse(Console.ReadLine());
                    while (minutes1 > 60F)
                    {
                        Console.Write("Minutes must be less than 60: ");
                        minutes1 = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter direction: ");
                    direction1 = char.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (direction1 == 'S' || direction1 == 'N')
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Enter a valid lattitude: ");
                            direction1 = char.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Enter ship longitude: ");
                    Console.Write("Enter degree: ");
                    degree2 = int.Parse(Console.ReadLine());
                    while (degree2 > 180)
                    {
                        Console.Write("Longitude must be less than 180 degrees: ");
                        degree2 = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Enter minutes: ");
                    minutes2 = float.Parse(Console.ReadLine());
                    while (minutes2 > 60F)
                    {
                        Console.Write("Minutes must be less than 60: ");
                        minutes2 = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Enter direction: ");
                    direction2 = char.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (direction2 == 'E' || direction2 == 'W')
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Enter a valid lattitude: ");
                            direction2 = char.Parse(Console.ReadLine());
                        }
                    }

                    slattitude = degree1.ToString() + "\u00b0" + minutes1.ToString() + "'" + direction1;
                    slongitude = degree2.ToString() + "\u00b0" + minutes2.ToString() + "'" + direction2;
                    x.shipLattitude = slattitude;
                    x.shipLongitude = slongitude;

                    Angle lattitude = new Angle(degree1, minutes1, direction1);
                    Angle longitude = new Angle(degree2, minutes2, direction2);


                    Ship sh = new Ship(number, slattitude, slongitude);
                    
                    
                }
            }

            if(!flag)
            {
                Console.Write("No ship found");
            }
            
            
        }
        static void SearchNumber(string lat , string log , List<Ship> s )
        {
            bool flag = false;
            foreach(Ship x in s)
            {
                if(lat == x.shipLattitude && log == x.shipLongitude)
                {
                    Console.WriteLine("Ship serial number is: " + x.shipNumber);
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                Console.Write("No ship found");
            }
            Console.ReadKey();
        }
        static void SearchShip(List<Ship> s , string number)
        {
            bool flag = false;
            foreach(Ship x in s)
            {
                if(number == x.shipNumber)
                {
                    Console.WriteLine("Ship is at " + x.shipLongitude + " and " + x.shipLattitude);
                    flag = true;
                    break;
                }
            }

            if(!flag)
            {
                Console.Write("No ship found");
            }

            Console.ReadKey();

        }
        static void AddToList(Ship s , List<Ship> sh)
        {
            sh.Add(s);
        }
        static Ship addShip()
        {
            string number;
            int degree1 , degree2;
            float minutes1 , minutes2;
            char direction1 , direction2;

            string slattitude, slongitude;
            Console.Write("Enter ship serial number: ");
            number = Console.ReadLine();

            Console.WriteLine("Enter ship lattitude: ");
            Console.Write("Enter degree: ");
            degree1 = int.Parse(Console.ReadLine());
            while(degree1 > 90)
            {
                Console.Write("Latittude must be less than 90 degrees: ");
                degree1 = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter minutes: ");
            minutes1 = float.Parse(Console.ReadLine());
            while(minutes1 > 60F)
            {
                Console.Write("Minutes must be less than 60: ");
                minutes1 = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter direction: ");
            direction1 = char.Parse(Console.ReadLine());
            while (true)
            {
                if(direction1 == 'S' || direction1 == 'N')
                {
                    break;
                }
                else
                {
                    Console.Write("Enter a valid lattitude: ");
                    direction1 = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter ship longitude: ");
            Console.Write("Enter degree: ");
            degree2 = int.Parse(Console.ReadLine());
            while (degree2 > 180)
            {
                Console.Write("Longitude must be less than 180 degrees: ");
                degree2 = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter minutes: ");
            minutes2 = float.Parse(Console.ReadLine());
            while (minutes2 > 60F)
            {
                Console.Write("Minutes must be less than 60: ");
                minutes2 = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter direction: ");
            direction2 = char.Parse(Console.ReadLine());
            while (true)
            {
                if (direction2 == 'E' || direction2 == 'W')
                {
                    break;
                }
                else
                {
                    Console.Write("Enter a valid lattitude: ");
                    direction2 = char.Parse(Console.ReadLine());
                }
            }




            slattitude = degree1.ToString() + "\u00b0" + minutes1.ToString() + "'" + direction1;
            slongitude = degree2.ToString() + "\u00b0" + minutes2.ToString() + "'" + direction2;


            Angle lattitude = new Angle(degree1 , minutes1 , direction1);
            Angle longitude = new Angle(degree2, minutes2, direction2);


            Ship s = new Ship(number, slattitude, slongitude);


            return s;
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1.Add ship");
            Console.WriteLine("2.View ship position");
            Console.WriteLine("3.View ship serial number");
            Console.WriteLine("4.Chage ship position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
