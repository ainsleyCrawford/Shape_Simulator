using System;

namespace Shape_Simulator
{
    public class Ellipse : Shape
    {
        int horizontalDiameter = 300;
        int verticalDiameter = 200;

        public Ellipse(int x, int y, int horizontalDiamater, int verticalDiameter)
            : base(x, y)
        {
            this.horizontalDiameter = horizontalDiameter;
            this.verticalDiameter = verticalDiameter;
        }
        public override void Print()
        {
            Console.WriteLine($"Ellipse\t({x},{y})\tdiameterH={horizontalDiameter}\tdiameterV={verticalDiameter}");
        }
    }
}
