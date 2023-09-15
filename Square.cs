using System;

namespace Shape_Simulator
{
    public class Square: Shape
    {
        private int size;
        private int Size
        {
            get => size;
            set => size = value;
        }
        public Square(int x, int y, int size): base(x, y)
        {
            Size = size;
        }
        public override void Print()
        {
            Console.WriteLine($"Square\t\t({X},{Y})\tsize={size}");
        }
    }
}