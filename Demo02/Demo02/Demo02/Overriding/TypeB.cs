using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // To Apply Override:
        // 1. Using 'new' Keyword[Default]:
        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }
        // 2. Using 'override' Keyword:
        // Must the function of parent : (public + Virtual)
        public override void Fun02()
        {
            Console.WriteLine($"A: {A} B: {B}");
        }
    }
}
