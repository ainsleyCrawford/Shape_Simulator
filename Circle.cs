using System;

namespace Shape_Simulator
{
    class Circle: Shape
    {
        private int size;
        private int Size
        {
            get => size;
            set => size = value;
        }
        public Circle(int x, int y, int size): base(x, y) => Size = size;
        public override void Print() => Console.WriteLine($"Circle\t\t({X},{Y})\tsize={size}");
    }
}