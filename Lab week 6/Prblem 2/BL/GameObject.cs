using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prblem_2.BL
{
    class GameObject
    {
        public void Move()
        {

            if (Direction == "LeftToRight")
            {
                MoveLeftToRight();
            }
            else if (Direction == "RightToLeft")
            {
                MoveRightToLeft();
            }

            else if (Direction == "Patrol")
            {
                MovePatrol();
            }

            else if(Direction == "Diagonal")
            {
                MoveDiagonal();
            }
        }



        public void MoveDiagonal()
        {
            if (StartPoint.x <= Premises.bottomRight.y)
            {
                Remove();
                StartPoint.y++;
                StartPoint.x++;
                for (int i = 0; i < Shape.GetLength(0); i++)
                {
                    for (int j = 0; j < Shape.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                        Console.Write(Shape[i, j]);
                    }
                }
            }
        }
        public void MovePatrol()
        {
            
            if(d == "left")
            {
                if (StartPoint.y > Premises.topLeft.x)
                {
                    Remove();
                    StartPoint.y--;

                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                            Console.Write(Shape[i, j]);
                        }
                    }
                    
                }
                else
                {
                    d = "right";
                }

            }
            else if(d == "right")
            {
                if (StartPoint.y >= Premises.topLeft.x)
                {
                    Remove();
                    StartPoint.y++;

                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                            Console.Write(Shape[i, j]);
                        }
                    }
                }
                else
                {
                    d = "left";
                }
            }
        }
        public void MoveRightToLeft()
        {
            if (StartPoint.y > Premises.topLeft.x)
            {
                Remove();                
                StartPoint.y--;

                for (int i = 0; i < Shape.GetLength(0); i++)
                {
                    for (int j = 0; j < Shape.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                        Console.Write(Shape[i, j]);
                    }
                }
            }
        }
        public void MoveLeftToRight()
        {
            
                Remove();                
                StartPoint.y++;

                for (int i = 0; i < Shape.GetLength(0); i++)
                {
                    for (int j = 0; j < Shape.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                        Console.Write(Shape[i, j]);
                    }
                }
            
        }
        public void Remove()
        {
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartPoint.y + j, StartPoint.x + i);
                    Console.Write(" ");
                }
            }

        }

        public void Draw()
        {

        }
        public GameObject(char[,] Shape , Point StartPoint , Boundry Premises , string Direction)
        {
            this.Shape = Shape;
            this.StartPoint = StartPoint;
            this.Premises = Premises;
            this.Direction = Direction;
            d = "left";

        }
        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' }};
            StartPoint = s;
            Premises = P;
            Direction = "Diagonal";
            d = "left";
        }
        public char[,] Shape;
        public Point StartPoint;
        public Boundry Premises;
        public string Direction;
        public string d;
        Boundry P = new Boundry();
        Point s = new Point(0,15);
    }
}
