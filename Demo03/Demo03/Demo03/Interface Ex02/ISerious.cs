using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex02
{
    internal interface ISerious
    {
        public int Current { get; set; } // 0
        void Next();
        void Reset()
        {
            Current = 0;
        }
    }
}
