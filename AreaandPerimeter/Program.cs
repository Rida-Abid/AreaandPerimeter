using System;
using System.Collections.Immutable;
using System.Drawing;

namespace AreaandPerimeter
{
    class Program
    {
        public static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Enter Shape(T for triangle,R for rectangle,S for square), Length , bredth and height ");
                Console.ReadLine();
                
            }
            else
            {
                
                string sides = Convert.ToString(args[0]);
                double length = Convert.ToDouble(args[1]);
                double bredth = Convert.ToDouble(args[2]);
                double height = Convert.ToDouble(args[3]);
                var logic = new Logic();

                if (length < 0)
                {
                    Console.WriteLine("Please enter length greater than 0");
                }
                if (bredth < 0)
                {
                    Console.WriteLine("Please enter height greater than 0");
                }
                if (height < 0)
                {
                    Console.WriteLine("Please enter height greater than 0");
                }

                if (args[0] == "S")
                {
                   

                    Results("Perimeter of Square is:", logic.perimeterofsquare(length));

                    Results("Area of Square is:", logic.areaofsquare(length));

                }
                else if(args[0] == "R")
                {

                    Results("Perimeter of Rectangle is:", logic.perimeterofrectangle(length, bredth));

                    Results("Area of Rectangle is ", logic.areaofrectangle(length, bredth));
                }
                else
                {
                    
                    Results("Perimeter of Triangle is:", logic.perimeteroftriangle(length, bredth, height));

                    Results("Area of Triangle is ", logic.areaoftriangle(length, bredth));

                }
            }

            




        }

        private static void Results(string heading, double value)
        {
            Console.WriteLine(heading);
            Console.WriteLine("-----------------------------");

            Console.WriteLine(value);
            
        }

    }   






}