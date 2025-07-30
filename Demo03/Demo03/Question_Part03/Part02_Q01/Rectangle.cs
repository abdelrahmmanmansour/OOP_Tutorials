using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q01
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape : Rectangle");
            Console.WriteLine($"Area oF Rectangle: {Width * Length}");
        }
    }
}
