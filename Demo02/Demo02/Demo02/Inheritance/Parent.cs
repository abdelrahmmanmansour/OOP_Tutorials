using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Inheritance
{
    internal class Parent
    {
        // Automatic Property:
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor:
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method:
        public void Fun01()
        {
            Console.WriteLine($"X: {X} Y: {Y}");
        }
        public void Fun02()
        {
            Console.WriteLine("I am Parent Class");
        }
        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }
    }
}
