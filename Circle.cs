using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Circle ({0},{1}) size={2}", x, y, size);
        }
    }
}
