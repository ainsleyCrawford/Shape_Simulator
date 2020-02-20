using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Ellipse ({0},{1}) diameterH={2} diameterV={3}", x, y, horizontalDiameter, verticalDiameter);
        }
    }
}
