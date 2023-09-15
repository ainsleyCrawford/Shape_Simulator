using System;

namespace Shape_Simulator
{
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;
        public Rectangle(int x, int y, int width, int height)
            : base(x, y)
        {
            this.width = width;
            this.height = height;
        }
        public override void Print()
        {
            Console.WriteLine($"Rectangle\t({x},{y})\twidth={width}\theight={3}");
        }
    }
}
