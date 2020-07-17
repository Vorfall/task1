using System;

namespace FiguresClassLibrary
{
    /// <summary>
    /// Represents Triagnle.
    /// </summary>
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        /// <summary>
        /// initializes using the sides of the triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double e, double f, double g)
        {
            if (f + g > e && e > 0)
            {
                a = e;
            }
            else
            {
                throw new Exception("Side a cannot belong to a rectangle");
            }
            if (e + g  > f && f > 0)
            {
                b = f;
            }
            else
            {
                throw new Exception("Side b cannot belong to a rectangle");
            }
            if (e + f > g && g > 0)
            {
                c = g;
            }
            else
            {
                throw new Exception("Side c cannot belong to a rectangle");
            }
            
        }
        /// <summary>
        /// Getting line length from points
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>

        public double PartyСreation(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


        /// <summary>
        /// initializes using triangle coordinates
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// 

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double e = PartyСreation(x1, y1, x2, y2);
            double f = PartyСreation(x2, y2, x3, y3);
            double g = PartyСreation(x3, y3, x1, y1);

            if (f + g > e && e > 0)
            {
                a = e;
            }
            else
            {
                throw new Exception("Side a cannot belong to a rectangle");
            }
            if (e + g > f && f > 0)
            {
                b = f;
            }
            else
            {
                throw new Exception("Side b cannot belong to a rectangle");
            }
            if (e + f > g && g > 0)
            {
                c = g;
            }
            else
            {
                throw new Exception("Side c cannot belong to a rectangle");
            }
        }



        /// <summary>
        /// Perimeter calculation
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Calculating area
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Getting HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode();
        }


        /// <summary>
        /// Converting object data to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"Type: { GetType().ToString()}, a = {a}, b ={b}, c ={c}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
        }

        /// <summary>
        /// Compares objects for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> equal / not equal <> true/else</returns>
        public override bool Equals(object obj)
        {
            if (obj is Triangle triangle)
            {
                if (this.a == triangle.a && this.b == triangle.b && this.c == triangle.c)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
