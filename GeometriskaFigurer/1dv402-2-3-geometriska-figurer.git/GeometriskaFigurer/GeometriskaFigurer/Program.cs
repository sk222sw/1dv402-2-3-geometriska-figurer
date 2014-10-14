using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    enum ShapeType
    {
        Ellipse = 1,
        Rectangle,
    }

    class Program
    {

        static void Main(string[] args)
        {
            ViewMenu();  //1 - Visa menu och gör val


            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 0:
                    return;
                case 1:
                    ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                    break;
                case 2:
                    ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                    break;
            }

        }

        private static Shape CreateShape(ShapeType shapeType)
        {


            Console.Clear();
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
                    Console.WriteLine("~\t     Ellipse      \t~");
                    Console.WriteLine("~._._._._._._._._._._._._._._._.~");
                    Console.ResetColor();
                    Console.WriteLine();
                    break;
                case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
                    Console.WriteLine("~\t    Rektangel   \t~");
                    Console.WriteLine("~._._._._._._._._._._._._._._._.~");
                    Console.ResetColor();
                    Console.WriteLine();
                    break;
            }

            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange bredden: ");

            Console.Clear();
            if (shapeType == ShapeType.Ellipse)
            {
                Shape ellipse = new Ellipse(length, width);
                return ellipse;
            }
            else
            {
                Shape rectangle = new Rectangle(length, width);
                return rectangle;
            }

        }

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
