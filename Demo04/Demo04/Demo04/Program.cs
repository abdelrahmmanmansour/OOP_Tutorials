using Demo04.Abstraction;
using Demo04.Partial_KeyWord;
using Demo04.Static_KeyWord;
using Demo04.Sealed_KeyWord;
using Demo04.Operator_Overloading;
namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            // Abstraction: التجريد
            // الحاجة مجردة من تفاصيلها
            // abstract : C# Keyword [Class - Method - Property]
            // I Can't Make Object From Any Abstract Class
            // Shape shape = new Shape();
            Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 5 };
            Console.WriteLine(rectangle.GetArea()); // 50 
            Console.WriteLine(rectangle.Premiter); // 100
            rectangle.Print(); // "I'm Rectangle" 
            #endregion
            #region Interface VS Abstraction
            // Interface VS Abstraction:
            // Interface : Code Concruct
            // Abstraction : Partial Class[Not Fully Implemented]
            // Interface : [Signature Of Method + Signature Of Property + Default Implemented Method]
            // Abstraction [Attribute+Method+Property+Event+abstract Method+abstract Property]
            // Interface : Default Access Modifier => Public
            // Abstraction : Default Access Modifier => Private 
            #endregion
            #region Operator Overloading
            // Operator Overloading:
            // +,-,*,/,==,!=,++,--,>=,<=
            // Complex Number: Real Number + Imaginary Number [5 + 6i]
            Complex c01 = new Complex() { Real = 1, Img = 6 };
            Complex c02 = new Complex() { Real = 7, Img = 2 };
            Console.WriteLine(c01);
            Console.WriteLine(c02);
            // 1- (+,- Operator):
            Complex c03 = c01 + c02;
            Complex c04 = c01 - c02;
            Console.WriteLine(c03);
            Console.WriteLine(c04);
            // 2- (++,-- Operator):
            c03++;
            Console.WriteLine(c03);
            c04--;
            Console.WriteLine(c04);
            // 3- (Comparsion [>,<]):
            if (c01 > c02)
            {
                Console.WriteLine("c01 is greater than c02");
            }
            else
            {
                Console.WriteLine("c01 is not greater than c02");
            }
            if (c01 <= c02)
            {
                Console.WriteLine("c01 is less than or equall c02");
            }
            else
            {
                Console.WriteLine("c01 is not less than or equall c02");
            }
            if (c01 == c02)
            {
                Console.WriteLine("c01 is equall c02");
            }
            else
            {
                Console.WriteLine("c01 is not equall c02");
            }
            // User Defined Casting Operator(Manual Mapping):
            // Convert complex to string
            string s = (string)c01;
            int x = (int)c01;
            Console.WriteLine(s);
            Console.WriteLine(x);
            #endregion
            #region Static KeyWord[Class - Method - Property - Constructor - Attribute]
            // Static KeyWord[Class - Method - Property - Constructor - Attribute]:
            Console.WriteLine(Utlites.CmToEnsh(254));
            Console.WriteLine(Utlites.PI);
            Console.WriteLine(Utlites.PIpi);
            #endregion
            #region Sealed KeyWord[Class - Method - Property]
            // Sealed KeyWord[Class - Method - Property]:
            // I Can't Inherit from sealed 
            #endregion
            #region Partial KeyWord[Class]
            // Partial KeyWord[Class]:
            Employee employee = new Employee();
            // employee has name,id
            #endregion
        }
    }
}
