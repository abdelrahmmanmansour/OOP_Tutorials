using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q01
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public double Radious { get; set; }

        public void DisplayShapeInfo()
        {
            const double PI = Math.PI;  // 3.141592653589793
            Console.WriteLine("Shape : Circle");
            Console.WriteLine($"Area Of Circle: {Radious * Radious * PI}");
        }
    }
}
