using System;

namespace FiguresClassLibrary
{
    /// <summary>
    /// Represents Rectangle.
    /// </summary>
    public class Rectangle : Figure
    {
        public double a;
        public double b;
        public double c;
        public double d;

        /// <summary>
        /// Initializes a rectangle based on the sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public Rectangle(double e, double f, double g, double h)
        {
            if(h + f + g > e && e > 0 )
            {
                a = e;
            }
            else
            {
                throw new Exception("Side A cannot belong to a rectangle");
            }
            if ( e + g + h > f && f > 0)
            {
               b = f;
            }
            else
            {
                throw new Exception("Side B cannot belong to a rectangle");
            }
            if (e + f + h > g &&  g > 0 )
            {
                c = g;
            }
            else
            {
                throw new Exception("Side C cannot belong to a rectangle");
            }
            if (e + f + g > h && h > 0)
            {
                d = h;
            }
            else
            {
                throw new Exception("Side D cannot belong to a rectangle");
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
        /// Initializes a rectangle based on the coordinate.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param> 
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="x4"></param>
        /// <param name="y4"></param>
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double e = PartyСreation(x1, y1, x2, y2);
            double f = PartyСreation(x2, y2, x3, y3);
            double g = PartyСreation(x3, y3, x4, y4);
            double h = PartyСreation(x4, y4, x1, y1); ;
            if (h + f + g > e && e > 0)
            {
                a = e;
            }
            else
            {
                throw new Exception("Side A cannot belong to a rectangle");
            }
            if (e + g + h > f && f > 0)
            {
                b = f;
            }
            else
            {
                throw new Exception("Side B cannot belong to a rectangle");
            }
            if (e + f + h > g && g > 0)
            {
                c = g;
            }
            else
            {
                throw new Exception("Side C cannot belong to a rectangle");
            }
            if (e + f + g > h && h > 0)
            {
                d = h;
            }
            else
            {
                throw new Exception("Side D cannot belong to a rectangle");
            }
        }



        /// <summary>
        /// Perimeter calculation
        /// </summary>
        /// <returns>P</returns>
        public override double GetPerimeter()
        {
            return (a + b) * 2;
        }

        /// <summary>
        /// Calculating area
        /// </summary>
        /// <returns>S</returns>
        public override double GetArea()
        {
            return a * b;
        }

        /// <summary>
        /// Getting HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode() ^ d.GetHashCode();
        }

        /// <summary>
        /// Сonverting object data to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"Type: {GetType().ToString()}, A = {a}, B ={b}, C ={c}, D ={d}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
        }

        /// <summary>
        /// Compares objects for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> equal / not equal <> true/else</returns>
        public override bool Equals(object obj)
        {
            if (obj is Rectangle rectangle)
            {
                if (this.a == rectangle.a && this.b == rectangle.b && this.c == rectangle.c && this.d == rectangle.d)
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
