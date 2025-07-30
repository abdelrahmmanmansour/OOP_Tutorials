using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void Fun01()
        {
            Console.WriteLine("I am An Employee");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"Salay : ????");
        }
    }
}
