using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface_Ex03
{
    internal class Airplane : IMovable,IFlyable
    {
        // Implement all Member Explicity
        // These Member -> Interface Not Class
        // So Not have any Access Modifier
        // Make Reference from Interface -> Class Airplane to use all member
        int IMovable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMovable.Backward()
        {
            Console.WriteLine("Fly IMovable Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Fly IFlyable Backward");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Fly IMovable Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Fly IFlyable Forward");
        }

        void IMovable.Left()
        {
            Console.WriteLine("Fly IMovable Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Fly IFlyable Left");
        }

        void IMovable.Right()
        {
            Console.WriteLine("Fly IMovable Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Fly IFlyable Right");
        }
    }
}
