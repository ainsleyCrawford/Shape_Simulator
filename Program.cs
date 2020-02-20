using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Required Widgets
            Shape rectangle = new Rectangle(10, 10, 30, 40);
            Shape square = new Square(15, 30, 35);
            Shape ellipse = new Ellipse(100, 150, 300, 200);
            Shape circle = new Circle(1, 1, 300);
            Shape textbox = new Textbox(5, 5, 200, 100, "sample text");

            // Required Output
            string horizontalLine = "--------------------------------------------------------------";

            Console.WriteLine(horizontalLine);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(horizontalLine);
            rectangle.Print();
            square.Print();
            ellipse.Print();
            circle.Print();
            textbox.Print();
            Console.WriteLine(horizontalLine);

            Console.ReadKey();
        }
    }
}
