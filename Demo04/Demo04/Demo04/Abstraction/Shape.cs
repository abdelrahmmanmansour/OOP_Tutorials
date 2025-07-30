using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Abstraction
{
    internal abstract class Shape
    {
        // Abstract Class [Not Fully Implemennted Class]
        // When any method || Property in any class is abstract must this class abstract
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // How Can i Calculate This GetArea();
        // I Can't So Make This Method Abstract
        // Virtula Method
        public abstract double GetArea();
        // How Can i Calculate Premiter;
        // I Can't So Make This Property Abstract
        // Virtula Property
        public abstract double Premiter { get; }

        public void Print()
        {
            Console.WriteLine("I'm Shape");
        }
    }
}
