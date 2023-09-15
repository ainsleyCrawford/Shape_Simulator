using System;

namespace Shape_Simulator
{
    class Circle : Shape
    {
        int size;
        public Circle(int x, int y, int size)
            : base(x, y)
        {
            this.size = size;
        }
        public override void Print()
        {
            Console.WriteLine($"Circle ({x},{y}) size={size}");
        }
    }
}
