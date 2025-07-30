using Question_Part02.Task_One;
using Question_Part02.Task_Two;

namespace Question_Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-One : Types To Understand The Binding[new-override]
            // Task-One : Types To Understand The Binding[new-override]
            // Ex-1:
            A1 a1 = new A1();
            a1 = new B1();
            a1 = new C1();
            a1 = new D1();
            a1 = new E1();
            a1.Fun1(); //  Fun1 From A1
            a1.Fun2(); //  A: 0 , B: 0 , C: 0 

            // Ex-2:
            B1 b1 = new B1();
            b1 = new C1();
            b1 = new D1();
            b1.Fun1();  // fun1 from B1
            b1.Fun2(); // A: 0 , B: 0 , C: 0 

            // Ex - 3:
            C1 c1 = new C1();
            c1 = new D1();
            c1 = new E1();
            c1.Fun1();  // Fun1 From C1
            c1.Fun2(); // A: 0 , B: 0 , C: 0  
            #endregion
            #region Task-Two : Understand Access Modifiers[Protected - Private Protected - Internal Protected]
            // Task-Two : Understand Access Modifiers[Protected - Private Protected - Internal Protected]
            Parent_Test parent_Test = new Parent_Test()
            {
                Public = "Public", // Any Where
                // Private= "Private", //  Not Accessible [inside class only]
                // Protected= "Protected" // Not Accessible [Same class + Derived class]
                Protected_Internal = "Protected_Internal", // [same assembly + Derived class]
                Internal = "Internal", // same assembly
                // Private_Protected = "Private_Protected" // [Derived class only]
            };
            parent_Test.Print();

            Child_Test child_Test = new Child_Test()
            {
                Public = "Public", // Any Where
                // Private= "Private", //  Not Accessible [inside class only]
                // Protected= "Protected" // Not Accessible [Same class + Derived class]
                Protected_Internal = "Protected_Internal", // [same assembly + Derived class]
                Internal = "Internal", // same assembly
                // Private_Protected = "Private_Protected" // [Derived class only]
            };
            child_Test.Print();
            #endregion
        }
    }
}
