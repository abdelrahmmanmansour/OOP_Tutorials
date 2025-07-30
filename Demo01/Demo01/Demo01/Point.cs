using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Point
    {
        // Attributes:
        public int X;
        public int Y;
        // Constructor: Special Method[Name Like struct + No Return Type]
        // CLR: Generate Default Constructor(parameterless):
        // Will Make All Attributes With Default Value
        // if i not write the Default Constructor(parameterless):
        // CLR Will Generate Default Constructor
        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }
        // Create Parameterized Constructor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        // Methods:
        public void PrintAttributes()
        {
            Console.WriteLine($"{X} {Y}");
        }
        public override string ToString()
        {
            return "Abdelrahman Mansour";
        }
    }
}
