using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex03
{
    internal interface IFlyable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
