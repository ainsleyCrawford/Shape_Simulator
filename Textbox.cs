using System;

namespace Shape_Simulator
{
    class Textbox : Rectangle
    {
        string text;
        public Textbox(int x, int y, int width, int height, string text)
            : base(x, y, width, height)
        {
            this.text = text;
        }
        public override void Print()
        {
            Console.WriteLine($"Textbox\t({x},{y})\twidth={width}\theight={height}\tText=\"{text}\"");
        }
    }
}
