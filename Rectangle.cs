using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Rectangle ({0}, {1}) width={2} height={3}", x, y, width, height);
        }
    }
}
