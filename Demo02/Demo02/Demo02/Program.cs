using Demo02.Binding;
using Demo02.Inheritance;

namespace Demo02
{
    internal class Program
    {
        #region Method (Function) Overloading
        // Method (Function) Overloading:
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Sum(int x, double y)
        {
            return x + y;
        }
        static double Sum(double x, int y)
        {
            return x + y;
        }
        #endregion
        #region Binding
        // Binding:
        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null)
            {
                employee.Fun01();
                employee.Fun02();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Inheritance
            // Inheritance:
            // To Avoid DRY Concept
            // Base Class == Super Class == Parent Class
            // Derived Class == Sub Class == Child Class
            // In C# Not Support Multiple Inheritance(الكلاس ملهوش اكتر من أب- هو أب واحد)
            // In C# Support Multi Level Inheritance
            // Important Note:
            // When any class inherited from any class,
            // his(child) Constructor Chain to Parameteless Constructor(parent)
            Parent parent = new Parent(1, 2);
            Console.WriteLine(parent);
            parent.Fun01();
            parent.Fun02();
            Child child = new Child(4, 5, 6);
            child.Fun01();
            child.Fun02();
            Console.WriteLine(child);
            #endregion
            #region Polymorphism
            // Polymorphism: تعدد الاشكال(Function or Object)
            // Console.WriteLine(); Has 18 Pattern 
            #endregion
            #region Polymorphism Method (Function) Overloading
            // Polymorphism Method (Function) Overloading:
            // These Functions in Same Scope
            // Overloading: Functions[Same Name + Different Signuture + Static Biding]
            // Signuture[Count - Type - Order]
            Console.WriteLine(Sum(1, 2, 3)); // (int,int,int)
            Console.WriteLine(Sum(1, 2));   // (int,int)
            Console.WriteLine(Sum(1, 2.5)); // (int,double)
            Console.WriteLine(Sum(1.4, 2)); // (double,int)
            Console.WriteLine(Sum(12.2, 2.1)); // (double,double) 
            #endregion
            #region Polymorphism Method (Function) Overriding:[Inheritance]
            // Polymorphism Method (Function) Overriding:[Inheritance]
            // Different Class + Different Behaviour[Body]
            // Overriding: Functions[Same Name + Same Signuture + Dynamic Biding]
            // Object initilizer:
            TypeB typeB = new TypeB() { A = 1, B = 2 };
            typeB.Fun01();
            typeB.Fun02();
            #endregion
            #region What is The Binding
            // What is The Binding:
            // Reference of parent -> object of child
            // Static Binding(new):  At Compile Time 
            // Compiler Will Bind Function call Based on Refrence Type not Object Type
            // Dynamic Binding(override):  At Run Time 
            // Compiler Will Bind Function call Based on Object Type not Refrence Type
            TypeA typeA = new TypeA();
            typeA = new TypeB(); // TypeB is a TypeA
            // typeA : See all in TypeA only not TypeB
            // But in override function:
            typeA.Fun01(); // new Keyword: so fun01 in TypeA
            typeA.Fun02(); // override Keyword: so fun01 in TypeB 
            #endregion
            #region When is this Not Binding
            // When is this Not Binding:
            // when U make Reference of child => object of parent
            //TypeB typeB1 = new TypeB();
            //typeB1 = (TypeB)new TypeA(); // Exciplict Casting Not Binding 
            #endregion
            #region When We Need To Binding
            // When We Need To Binding:
            FullTimeEmployee employee = new FullTimeEmployee()
            {
                Id = 1,
                Name = "Mansour",
                Email = "Mansour@gmail.com",
                Address = "Talkha",
                Salary = 12000
            };
            PartTimeEmployee partTime = new PartTimeEmployee()
            {
                Id = 1,
                Name = "Mona",
                Email = "Mona@gmail.com",
                Address = "Talkha",
                HourRate = 300,
                NumberOfHour = 200
            };
            EmployeeProcess(employee);
            EmployeeProcess(partTime);
            #endregion
            #region  Example About Binding[Important]
            // Example About Binding[Important]:
            TypeA Ref;
            Ref = new TypeA();
            Ref = new TypeB();
            Ref = new TypeC();
            Ref = new TypeD();
            Ref = new TypeE();
            Ref.A = 1;
            // Un Reachable:
            //Ref.B = 2;
            //Ref.C = 3;
            //Ref.D = 4;
            Ref.Fun01();  // Fun01 From TypeA
            Ref.Fun02();  // A,B,C,D,E 
            #endregion
        }
    }
}
