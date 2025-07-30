using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex01
{
    internal interface IMyTpe
    {
        // I can't Make Object From Any Interface
        // I can't Make Attributes in Interface
        // Default Accsess Modifier is Public
        // What Can Write Inside Interface:
        // 1. Signature Of Property[Like Automatic Property]:
        public double Salary { get; set; }
        // 2. Signature Of Method[Name of function , Parameter , Return Type] Only not have body(code):
        void MyFun();
        // 3.Default Implemented Method  [Fully Implemented Method]
        void Print()
        {
            Console.WriteLine("Fully Implemented Method");
        }
    }
}
