using System;

namespace Shape_Simulator
{
    class Textbox: Rectangle
    {
        private string text;
        private string Text
        {
            get => text;
            set => text = value;
        }
        public Textbox(int x, int y, int width, int height, string text): base(x, y, width, height)
        {
            Text = text;
        }
        public override void Print()
        {
            Console.WriteLine($"Textbox\t\t({X},{Y})\twidth={Width}\t\theight={Height}\tText=\"{text}\"");
        }
    }
}