using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part02.Task_One
{
    // Multi Level Inheritance:
    class A1
    {
        // Automatic Property:
        public int A { get; set; }

        // Method:
        public void Fun1()
        {
            Console.WriteLine("Fun1 From A1");
        }
        public virtual void Fun2()
        {
            Console.WriteLine($"A: {A}");
        }
    }

    class B1 : A1
    {
        // Automatic Property:
        public int B { get; set; }

        // Method:
        public new void Fun1()
        {
            Console.WriteLine("Fun1 From B1");
        }
        public override void Fun2()
        {
            Console.WriteLine($"A: {A} , B: {B}");
        }
    }

    class C1 : B1
    {
        // Automatic Property:
        public int C { get; set; }

        // Method:
        public new void Fun1()
        {
            Console.WriteLine("Fun1 From C1");
        }
        public override void Fun2()
        {
            Console.WriteLine($"A: {A} , B: {B} , C: {C}");
        }
    }

    class D1 : C1
    {
        // Automatic Property:
        public int D { get; set; }

        // Method:
        public new void Fun1()
        {
            Console.WriteLine("Fun1 From D1");
        }
        public virtual void Fun2()
        {
            Console.WriteLine($"A: {A} , B: {B} , C: {C} , D: {D}");
        }
    }

    class E1 : D1
    {
        // Automatic Property:
        public int E { get; set; }

        // Method:
        public new void Fun1()
        {
            Console.WriteLine("Fun1 From E1");
        }
        public new void Fun2()
        {
            Console.WriteLine($"A: {A} , B: {B} , C: {C} , D: {D} , E: {E}");
        }
    }
}
