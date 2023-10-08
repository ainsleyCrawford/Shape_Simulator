using System;
using System.Collections.Generic;

namespace Shape_Simulator
{
    class Program
    {
        static List<Shape> shapes = new List<Shape>();
        static string invalid = "Does not compute.\n";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, user!");
            Draw();

            string horizontalLine = "--------------------------------------------------------------";
            Console.Clear();
            Console.WriteLine(horizontalLine);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(horizontalLine);
            
            foreach(Shape shape in shapes) shape.Print();
            
            Console.WriteLine(horizontalLine);

            Console.ReadKey();
        }
        static void Draw()
        {
            Console.WriteLine("Which shape would you like to draw?\nr = Rectangle, s = Square, e = Ellipse, c = circle, t = textbox");
            switch (Console.ReadKey(true).Key) 
            {
                case ConsoleKey.R:
                    _Rectangle();
                    break;
                case ConsoleKey.S:
                    _Square();
                    break;
                case ConsoleKey.E:
                    _Ellipse();
                    break;
                case ConsoleKey.C:
                    _Circle();
                    break;
                case ConsoleKey.T:
                    _Textbox();
                    break;
                default:
                    Console.WriteLine(invalid);
                    FinishOrContinue();
                    break;
            }
        }
        #region Shapes
        static void _Rectangle()
        {
            int x, y, width, height;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a y coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out y));
            else
            {
                Console.WriteLine(invalid);
                Draw();

            }
            Console.Write("Enter a width: ");
            if (Int32.TryParse(Console.ReadLine(), out width));
            else
            {
                Console.WriteLine(invalid);
                Draw();

            }
            Console.Write("Enter a height: ");
            if (Int32.TryParse(Console.ReadLine(), out height));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            shapes.Add(new Rectangle(x, y, width, height));
            FinishOrContinue();
        }
        static void _Square()
        {
            int x, y, size;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a y coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out y));
            else
            {
                Console.WriteLine(invalid);
                Draw();

            }
            Console.Write("Enter a size: ");
            if (Int32.TryParse(Console.ReadLine(), out size));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            shapes.Add(new Square(x, y, size));
            FinishOrContinue();
        }
        static void _Ellipse()
        {
            int x, y, diameterH, diameterV;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a y coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out y));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a horizontal diameter: ");
            if (Int32.TryParse(Console.ReadLine(), out diameterH));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a vertical diameter: ");
            if (Int32.TryParse(Console.ReadLine(), out diameterV));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            shapes.Add(new Ellipse(x, y, diameterH, diameterV));
            FinishOrContinue();
        }
        static void _Circle()
        {
            int x, y, size;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a y coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out y));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a size: ");
            if (Int32.TryParse(Console.ReadLine(), out size));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            shapes.Add(new Circle(x, y, size));
            FinishOrContinue();
        }
        static void _Textbox()
        {
            int x, y, width, height;
            string text;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a y coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out y));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a width: ");
            if (Int32.TryParse(Console.ReadLine(), out width));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Enter a height: ");
            if (Int32.TryParse(Console.ReadLine(), out height));
            else
            {
                Console.WriteLine(invalid);
                Draw();
            }
            Console.Write("Type a message to display: ");
            text = Console.ReadLine();
            shapes.Add(new Textbox(x, y, width, height, text));
            FinishOrContinue();
        }
        #endregion
        static void FinishOrContinue()
        {
            Console.WriteLine("Key the spacebar to add another shape to your drawing.\nPress any other key to output your drawing.");
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) Draw();
        }
    }
}