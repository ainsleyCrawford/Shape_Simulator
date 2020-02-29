using System;

namespace Shape_Simulator
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        protected Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Print();
    }
}
