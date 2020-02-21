using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Simulator
{
    public class Instantiate
    {
        public Shape _Rectangle()
        {
            Shape rectangle = new Rectangle(10, 10, 30, 40);
            return rectangle;
        }
    }
}
