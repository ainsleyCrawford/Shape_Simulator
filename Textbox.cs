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
            Console.WriteLine("Textbox ({0},{1}) width={2} height={3} Text=\"{4}\"", x, y, width, height, text);
        }
    }
}
