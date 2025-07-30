using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex02
{
    internal class SeriousByFour : ISerious
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 4;
        }
    }
}
