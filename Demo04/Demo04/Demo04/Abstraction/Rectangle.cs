using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Abstraction
{
    internal class Rectangle : Shape // (:) => [Inherit(Fully Data) + Implement(Not Fully Data)]
    {
        // Concrete Class [Fully Implemennted Class]
        public override double Premiter
        {
            get
            {
                return (Dim01 * Dim02) * 2;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
        public void Print()
        {
            Console.WriteLine("I'm Rectangle");
        }
    }
}
