using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Sealed_KeyWord
{
    internal class TypeB:  TypeA
    {
        public int B { get; set; }
        public sealed override int A { get; set; }
        public sealed override void Fun()
        {
            Console.WriteLine("Fun from TypeB");
        }
    }
}
