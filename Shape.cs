using System;

namespace Shape_Simulator
{
    public abstract class Shape
    {
        private int x;
        private int y;
        protected int X
        {
            get => x;
            set => x = value;
        }
        protected int Y
        {
            get => y;
            set => y = value;
        }
        protected Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Print();
    }
}