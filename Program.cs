using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Simulator
{
    class Program
    {
        static List<Shape> shapes = new List<Shape>();
        static void Main(string[] args)
        {
            // Required Widgets
            //Shape rectangle = new Rectangle(10, 10, 30, 40);
            //Shape square = new Square(15, 30, 35);
            //Shape ellipse = new Ellipse(100, 150, 300, 200);
            //Shape circle = new Circle(1, 1, 300);
            //Shape textbox = new Textbox(5, 5, 200, 100, "sample text");
            
            
            Draw();

            // Required Output
            string horizontalLine = "--------------------------------------------------------------";

            Console.WriteLine(horizontalLine);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(horizontalLine);
            foreach(Shape shape in shapes)
            {
             //   shape.Print();
            }
            Console.WriteLine(horizontalLine);

            

            Console.ReadKey();
        }
        static void Draw()
        {
            string invalid = "Does not compute";
            Console.WriteLine("Which shape would you like to draw? \n" +
                "r = Rectangle, s = Square, e = Ellipse, c = circle, t = textbox");
            switch (Console.ReadKey(true).Key) 
            {
                case ConsoleKey.R:
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
                    break;
                case ConsoleKey.S:
                    //
                    break;
                case ConsoleKey.E:
                    //
                    break;
                case ConsoleKey.C:
                    //
                    break;
                case ConsoleKey.T:
                    //
                    break;
                default:
                    Console.WriteLine(invalid);
                    Draw();
                    break;
            }
            Console.WriteLine("Key the spacebar to add another shape to your drawing.\n" +
                "Press any other key to close the program.");
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) Draw();
        }
    }
}
