using System;

namespace Shape_Simulator
{
    public class Ellipse: Shape
    {
        private int horizontalDiameter;
        private int verticalDiameter;
        private int HorizontalDiameter
        {
            get => horizontalDiameter;
            set => horizontalDiameter = value;
        }
        private int VerticalDiameter
        {
            get => verticalDiameter;
            set => verticalDiameter = value;
        }
        public Ellipse(int x, int y, int horizontalDiamater, int verticalDiameter): base(x, y)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }
        public override void Print() => Console.WriteLine($"Ellipse\t\t({X},{Y})\tdiameterH={horizontalDiameter}\tdiameterV={verticalDiameter}");
    }
}
