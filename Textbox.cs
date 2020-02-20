using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Simulator
{
    class Textbox : Shape
    {
        int width;
        int height;
        string text;
        public Textbox(int x, int y, int width, int height, string text)
            : base(x, y)
        {
            this.width = width;
            this.height = height;
            this.text = text;
        }
        public override void Print()
        {
            Console.WriteLine("Textbox ({0},{1}) width={2} height={3} Text=\"{4}\"", x, y, width, height, text);
        }
    }
}
