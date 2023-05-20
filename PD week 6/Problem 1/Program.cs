using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;
            int option = 0;
            string path = "maze.txt";
            string path2 = "pacman.txt";
            
            Grid g = new Grid(path, 24, 71);
            Pacman p = new Pacman(10, 5, 0, g);
            Ghost g1 = new Ghost(15, 39, "left", 'R',  0.1F, ' ' , 1F, g);
            Ghost g2 = new Ghost(1, 1, "left", 'H', 0.1F, ' ', 1F, g);
            Ghost g3 = new Ghost(10, 15 ,"up", 'V', 0.1F, ' ', 1F, g);
            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(g1);
            enemies.Add(g2);
            enemies.Add(g3);

            
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    g.Draw();
                    while (gameRunning)
                    {
                        Thread.Sleep(90);
                        p.Remove();
                        p.Move();
                        p.Draw();
                        p.PrintScore();
                        foreach (Ghost i in enemies)
                        {
                            i.Remove();
                            i.Move();
                            i.Draw();

                        }
                        p.SaveData(path2);
                        if (g.IsStoppingCondition())
                        {
                            gameRunning = false;
                        }

                    }
                }
                else if(option == 2)
                {
                    p.LoadData(path2);
                    Console.Clear();
                    g.Draw();
                    while (gameRunning)
                    {
                        Thread.Sleep(90);
                        p.Remove();
                        p.Move();
                        p.Draw();
                        p.PrintScore();
                        foreach (Ghost i in enemies)
                        {
                            i.Remove();
                            i.Move();
                            i.Draw();

                        }
                        p.SaveData(path2);
                        if (g.IsStoppingCondition())
                        {
                            gameRunning = false;
                        }

                    }
                }

            } while (option != 3);
           
        }

        static int Menu()
        {
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Continue Game");
            Console.WriteLine("3.Exit");
            int option  = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
