using System;
using System.Collections.Generic;

namespace Shape_Simulator
{
    class Program
    {
        static List<Shape> shapes = new List<Shape>();
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
                    InvalidInput();
                    break;
            }
        }
        #region Shapes
        static void _Rectangle()
        {
            int x, y, width, height;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Enter a y coordinate: ");
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Enter a width: ");
                    if (Int32.TryParse(Console.ReadLine(), out width))
                    {
                        Console.Write("Enter a height: ");
                        if (Int32.TryParse(Console.ReadLine(), out height))
                        {
                            shapes.Add(new Rectangle(x, y, width, height));
                            FinishOrContinue();
                        }
                        else InvalidInput();
                    }
                    else InvalidInput();
                }
                else InvalidInput();
            }
            else InvalidInput();
        }
        static void _Square()
        {
            int x, y, size;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Enter a y coordinate: ");
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Enter a size: ");
                    if (Int32.TryParse(Console.ReadLine(), out size))
                    {
                        shapes.Add(new Square(x, y, size));
                        FinishOrContinue();
                    }
                    else InvalidInput();
                }
                else InvalidInput();
            }
            else InvalidInput();
        }
        static void _Ellipse()
        {
            int x, y, diameterH, diameterV;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Enter a y coordinate: ");
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Enter a horizontal diameter: ");
                    if (Int32.TryParse(Console.ReadLine(), out diameterH))
                    {
                        Console.Write("Enter a vertical diameter: ");
                        if (Int32.TryParse(Console.ReadLine(), out diameterV))
                        {
                            shapes.Add(new Ellipse(x, y, diameterH, diameterV));
                            FinishOrContinue();
                        }
                        else InvalidInput();
                    }
                    else InvalidInput();
                }
                else InvalidInput();
            }
            else InvalidInput();
        }
        static void _Circle()
        {
            int x, y, size;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Enter a y coordinate: ");
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Enter a size: ");
                    if (Int32.TryParse(Console.ReadLine(), out size))
                    {
                        shapes.Add(new Circle(x, y, size));
                        FinishOrContinue();
                    }
                    else InvalidInput();
                }
                else InvalidInput();
            }
            else InvalidInput();
        }
        static void _Textbox()
        {
            int x, y, width, height;
            string text;
            Console.Write("Enter an x coordinate: ");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Enter a y coordinate: ");
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Enter a width: ");
                    if (Int32.TryParse(Console.ReadLine(), out width))
                    {
                        Console.Write("Enter a height: ");
                        if (Int32.TryParse(Console.ReadLine(), out height))
                        {
                            Console.Write("Type a message to display: ");
                            text = Console.ReadLine();
                            shapes.Add(new Textbox(x, y, width, height, text));
                            FinishOrContinue();
                        }
                        else InvalidInput();
                    }
                    else InvalidInput();
                }
                else InvalidInput();
            }
            else InvalidInput();
        }
        #endregion
        static void InvalidInput()
        {
            Console.WriteLine("Does not compute.\n");
            FinishOrContinue();
        }
        static void FinishOrContinue()
        {
            Console.WriteLine("Key the spacebar to add another shape to your drawing.\nPress any other key to output your drawing.");
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) Draw();
        }
    }
}