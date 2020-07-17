using FiguresClassLibrary;
using System;

namespace ParsersLibrary
{
    /// <summary>
    /// Data parser, used to initialize data
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// interprets data as a triangle
        /// </summary>
        /// <param name="data"></param>
        /// <returns>triangle</returns>
        public Triangle ParseAsTriangle(string[] data)
        {
            if (data.Length == 4)
            {
                return new Triangle(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
            }
            else
            {
                return  new Triangle(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]),
                    int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
            }
        }

        /// <summary>
        /// interprets data as a circle
        /// </summary>
        /// <param name="data"></param>
        /// <returns>circle</returns>
        public Circle ParseAsCircle(string[] data)
        {
            if (data.Length == 2)
            {
                return new Circle(int.Parse(data[1]));
            }
            else
            {
                return new Circle(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
            }
        }

        /// <summary>
        /// interprets data as a rectangle
        /// </summary>
        /// <param name="data"></param>
        /// <returns>rectangle/returns>
        public Rectangle ParseAsRectangle(string[] data)
        {
            if (data.Length == 5)
            {
                return new Rectangle(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
            }
            else
            {
                return new Rectangle(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]),
                    int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8]));
            }
        }

    }
}
