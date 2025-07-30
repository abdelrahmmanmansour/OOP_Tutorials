using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part04.Second_Project
{
    internal static class Maths
    {
        public static double Add(double x, double y)
        {
            Console.Write("The Addition is: ");
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            Console.Write("The Subtraction is: ");
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            Console.Write("The Multiply is: ");
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            Console.Write("The Division is: ");
            return y != 0 ? x / y : 0;
        }
    }
}
