using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Inheritance
{
    internal class Child : Parent
    {
        // Automatic Property:
        public int Z { get; set; }

        // Constructor:
        // Chain Constructor to Parameterless of Parent[External chain Constructor]
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        // Method:
        // Override
        public void Fun01()
        {
            Console.WriteLine($"X: {X} Y: {Y} Z: {Z}");
        }
        public void Fun02()
        {
            Console.WriteLine("I am Child Class");
        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }
    }
}
