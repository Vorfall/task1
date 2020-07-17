using System;

namespace FiguresClassLibrary
{
    public class Circle : Figure
    {
        private double _r;

        public Circle(double r)
        {
            _r = r;
        }

        public Circle(int x1, int y1, int x2, int y2)
        {
            _r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double R { get => _r; set => _r = value; }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
