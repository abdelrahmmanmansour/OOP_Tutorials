using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex01
{
    internal class MyType : IMyTpe
    {
        // U can make Multiple Implemented to interface 
        // U Can Make Property(Full or Automatic)
        public double Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello,World");
        }
    }
}
