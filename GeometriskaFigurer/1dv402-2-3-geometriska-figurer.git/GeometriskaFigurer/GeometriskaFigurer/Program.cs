using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Program
    {
        enum ShapeType
        { 
            Ellipse = 0,
            Rectangle,
        }
        static void Main(string[] args)
        {
            double length;
            double width;
            int menuChoice;

            ViewMenu();

            ShapeType shape = ReadDoubleGreaterThanZero("Ange menyval [0-2]");
            Console.WriteLine();
            length = ReadDoubleGreaterThanZero("Ange längden: ");
            width = ReadDoubleGreaterThanZero("Ange bredden: ");

            Shape Shape = new Ellipse(length, width);



        }

        //private static Shape CreateShape(ShapeType shapetype)
        //{

        //    Shape = Ellipse;

        //}

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double userInput = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    userInput = double.Parse(Console.ReadLine());

                    if (userInput > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Fel! Det måste vara ett flyttal större än 0.");
                    }
                }
                catch 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! Ange ett flyttal.");
                }
                Console.ResetColor();
            }      
            return userInput;
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
            Console.WriteLine("~\t\t\t\t~");
            Console.WriteLine("~\tGeometriska figurer\t~");
            Console.WriteLine("~\t\t\t\t~");
            Console.WriteLine("~._._._._._._._._._._._._._._._.~");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine();
        }

        private static void ViewShapeDetail(Shape shape)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
            Console.WriteLine("~\t     Detaljer     \t~");
            Console.WriteLine("~._._._._._._._._._._._._._._._.~");
            Console.ResetColor();
            Console.WriteLine();
            
            

            Console.WriteLine();
            Console.WriteLine("=================================");
        }
    }
}
