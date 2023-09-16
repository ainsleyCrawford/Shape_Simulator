using System;

namespace Shape_Simulator
{
    public class Rectangle: Shape
    {
        private int width;
        private int height;
        protected int Width
        {
            get => width;
            set => width = value;
        }
        protected int Height
        {
            get => height;
            set => height = value;
        }
        public Rectangle(int x, int y, int width, int height): base(x, y)
        {
            Width = width;
            Height = height;
        }
        public override void Print() => Console.WriteLine($"Rectangle\t({X},{Y})\twidth={width}\t\theight={height}");
    }
}