using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01
{
    internal struct Point2D
    {
        #region Attributes
        // Attributes: 
        private double x;
        private double y;
        #endregion
        #region Parametrized Constructor
        // Constructor: 
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion
        #region Apply Encapsulation[Using Full Property]
        // Apply Encapsulation[Using Full Property]: 
        public double X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public double Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        #endregion
        #region To Calculates Distance between Two Point
        // Method:
        // To Calculates Distance between Two Point: 
        public double Distance(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        #endregion
    }
}
