using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Sealed_KeyWord
{
    internal class TypeA
    {
        public virtual int A { get; set; }
        public virtual void Fun()
        {
            Console.WriteLine("Fun from typeA");
        }
    }
}
