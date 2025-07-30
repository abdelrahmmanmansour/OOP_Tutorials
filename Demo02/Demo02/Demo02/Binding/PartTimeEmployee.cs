using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int HourRate { get; set; }
        public int NumberOfHour { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am An PartTimeEmployee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salay : {HourRate * NumberOfHour}");
        }
    }
}
