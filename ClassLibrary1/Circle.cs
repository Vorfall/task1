using System;

namespace FiguresClassLibrary
{
    /// <summary>
    ///  Represents circle.
    /// </summary>
    public class Circle : Figure
    {
        public double r;

        /// <summary>
        /// Constructor for initializing cirlce class by R
        /// </summary>
        /// <param name="r"></param>
        public Circle(double R)
        {
            if( R > 0)
            {
                r = R;
            }
            else
            {
                throw new Exception("R cannot be equal to 0");
            }
        }

        /// <summary>
        /// Coonstructor for initializing cirlce class by a center coords and a point on the circle edge
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Circle(double x1, double y1, double x2, double y2)
        {
            if ( x1 != x2 && y1 != y2)
            {
                r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            else
            {
                throw new Exception("Wrong coordinats");
            }
        }

        /// <summary>
        /// Radius accessor 
        /// </summary>
     

        /// <summary>
        /// Overriden method from the parent class. Calculates P.
        /// </summary>
        /// <returns>P</returns>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }

        /// <summary>
        /// Overriden method from the parent class. Calculates S.
        /// </summary>
        /// <returns>S</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Generates HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return r.GetHashCode();
        }

        /// <summary>
        /// Displays data about an object
        /// </summary>
        public override string ToString()
        {
            return string.Format($"Type: {GetType().ToString()}, Perimeter = { GetPerimeter()}, Area = {GetArea()}, R = {r}");
        }
        /// <summary>
        /// Compares objects for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> equal / not equal <> true/else</returns>
        public override bool Equals(object obj)
        {
            if(obj is Circle circle)
            {
                return this.r == circle.r;
            }

            return false;
        }
    }
}
