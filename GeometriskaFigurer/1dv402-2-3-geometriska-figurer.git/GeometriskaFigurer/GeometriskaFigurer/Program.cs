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
        static void Main(string[] args)     //Visar meny och kör metoden ViewShapeDetail
        {
            do
	        {
                ViewMenu();  //1 - Visa menu och gör val
                int menuChoice;
                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
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
                    if (menuChoice < 0 || menuChoice > 2)
                    {
                        throw new ArgumentException();
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! Det måste vara ett heltal mellan 0 och 2.");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Tryck för att köra igen.");
                    Console.ResetColor();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Shape CreateShape(ShapeType shapeType)       //Låter användaren ange bredd och längd och returnerar ellips/rektangel med bredd och längd.
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
            if (shapeType == ShapeType.Ellipse)     //Returnerar rätt typ av figur
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

        private static double ReadDoubleGreaterThanZero(string prompt)  //Används för att läsa in längd och bredd, och kontrollerar så att det är rätt typ.
        {
            double userInput;
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    userInput = double.Parse(Console.ReadLine());
                    if (userInput > 0)
                    {
                        return userInput;
                    }
                    throw new ArgumentException();
                }
                catch 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fel! Ange ett flyttal större än 0.");
                }
                Console.ResetColor();
                Console.WriteLine();
            }      
        }

        private static void ViewMenu()          //Skriver ut en meny.
        {
            Console.Clear();
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

        private static void ViewShapeDetail(Shape shape)                //Anropar ToString()-metoden som innehåller en formatering av vad som ska skrivas ut...
        {                                                               //sedan skrivs detaljer kring valda figur ut.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
            Console.WriteLine("~\t     Detaljer     \t~");
            Console.WriteLine("~._._._._._._._._._._._._._._._.~");
            Console.ResetColor();

            Console.WriteLine(shape.ToString());

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tryck för att köra igen - Esc avslutar");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
