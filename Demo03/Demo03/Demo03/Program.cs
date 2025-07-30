using Demo03.Builtin_Interface;
using Demo03.Interface_Ex01;
using Demo03.Interface_Ex02;
using Demo03.Interface_Ex03;

namespace Demo03
{
    internal class Program
    {
        #region Interface Ex02:
        static void PrintNumber(ISerious serious, int x)
        {
            if (x == 2)
            {
                Console.Write("The Result Of SeriousByTwo: ");
            }
            else if (x == 3)
            {
                Console.Write("The Result Of SeriousByThree: ");
            }
            else
            {
                Console.Write("The Result Of SeriousByFour: ");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{serious.Current} ");
                serious.Next();
            }
            serious.Reset();
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Interface
            // Interface: Code Contruct Between Developer Who Write it And Developer Who Use it
            // عقد بين طرفين لازم الاطراف تنفذ بنود العقد بالظبط
            // الاهمية هى الاجبااار
            // I can't Make Object From Any Interface
            // I can't Make Attributes in Interface
            // Default Accsess Modifier is Public
            // IMyType myType = new IMyType(); Invalid
            // Solve it: Create Class Which Implemented this Interface 
            #endregion
            #region Interface Ex01
            // Interface Ex01:
            MyType myType = new MyType() { Salary = 12000 };
            Console.WriteLine(myType.Salary);
            myType.MyFun();
            // I Can Create Reference Of Inteface -> Object from Class Who Implemented this interface
            IMyTpe myType1 = new MyType() { Salary = 15000 };
            Console.WriteLine(myType1.Salary);
            myType1.MyFun();
            myType1.Print();
            #endregion
            #region Interface Ex02
            // Interface Ex02:
            SeriousByTwo seriousByTwo = new SeriousByTwo();
            SeriousByThree seriousByThree = new SeriousByThree();
            SeriousByFour seriousByFour = new SeriousByFour();
            PrintNumber(seriousByFour, 4);
            #endregion
            #region Interface Ex03
            // Interface Ex03:
            // Multiple Inheritance: Make Diamond Problem
            // Diamond Problem: Class A(Classes B,C Inherit from calss A),Class D Inherit from calss C
            // Class D have Two Function like print(C,A), this is a problem
            Car car = new Car();
            car.Forward();
            car.Backward();
            car.Left();
            car.Right();
            IMovable movable = new Airplane();
            movable.Forward();
            movable.Backward();
            movable.Left();
            movable.Right();
            IFlyable flyable = new Airplane();
            flyable.Forward();
            flyable.Backward();
            flyable.Left();
            flyable.Right();
            #endregion
            #region Shallow Copy VS Deep Copy
            // Shallow Copy VS Deep Copy:
            // Object Consist of: Identity(Address), Object State(Data)

            // EX01:
            // Shallow Copy(Copy Identity)
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = { 4, 5, 6 };
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            // Copy Identity
            // { 1, 2, 3 }; -> Has Two Reference Arr01,Arr02
            // { 4, 5, 6 }; -> UnReachable Object
            Arr02 = Arr01;
            Console.WriteLine();
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            Arr01[0] = 5;
            Console.WriteLine(Arr02[0]); // 5
            Console.WriteLine();
            // Deep Copy(Copy Object State(Data)):
            // Clone Method: Copy Object State(Data) of Caller(Arr01)
            // Assign New Object to Arr02 + Generate New Identity(Address)
            Arr02 = (int[])Arr01.Clone(); // Casting
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            Arr01[0] = 5; ;
            Console.WriteLine(Arr02[0]); // 1

            // EX02:
            string[] Arr1 = { "Ahmed", "Mansour", "Leqaa" };
            string[] Arr2 = { "Mohamed", "Ayman", "Ola" };
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            // Copy Identity
            // { "Ahmed", "Mansour", "Leqaa" }; -> Has Two Reference Arr1,Arr2
            // { "Mohamed", "Ayman", "Ola" }; -> UnReachable Object
            // Shallow Copy(Copy Identity)
            Arr2 = Arr1;
            Console.WriteLine();
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            Arr1[0] = "Mariam";
            Console.WriteLine(Arr2[0]); // Mariam
            Console.WriteLine();
            // Deep Copy(Copy Object State(Data)):
            // Clone Method: Copy Object State(Data) of Caller(Arr01)
            // Assign New Object to Arr02 + Generate New Identity(Address)
            Arr2 = (string[])Arr1.Clone(); // Casting
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            Arr1[1] = "Moha";
            Console.WriteLine(Arr2[0]); // Mariam 
            #endregion
            #region Built in Interface - ICloneable
            // Built in Interface - ICloneable:
            // To Use Clone Method if this calss not have Clone Method
            // Use Built in Interface - ICloneable
            Employee employee01 = new Employee() { Id = 1, Name = "Mansour", Age = 22, Salary = 12000 };
            Employee employee02 = new Employee() { Id = 2, Name = "Moha", Age = 22, Salary = 12000 };
            employee02 = employee01; // Shallow Copy
            Console.WriteLine(employee01.GetHashCode());
            Console.WriteLine(employee02.GetHashCode());
            employee02 = (Employee)employee01.Clone();
            //employee02 = new Employee(employee01); // Copy Constructor
            Console.WriteLine(employee01.GetHashCode());
            Console.WriteLine(employee02.GetHashCode());
            Console.WriteLine(employee01);
            Console.WriteLine(employee02);
            #endregion
            #region Built in Interface - ICompareable
            // Built in Interface - ICompareable
            // If U Want To Rearrange Elements not integer 
            // Use Built in Interface - ICompareable
            Employee[] employees = new Employee[3]
            {
               new Employee(){Id = 1, Name = "Mansour", Age = 22, Salary = 12000},
               new Employee(){Id = 2, Name = "Mona", Age = 26, Salary = 18000},
               new Employee(){Id = 3, Name = "Sara", Age = 29, Salary = 20000},
            };
            Array.Sort(employees);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion
            #region Built in Interface - IComparer
            // Built in Interface - IComparer: 
            // If U Want to Compare :
            Employee[] employees01 = new Employee[3]
            {
               new Employee(){Id = 1, Name = "Mansour", Age = 22, Salary = 12000},
               new Employee(){Id = 2, Name = "Mona", Age = 26, Salary = 40000},
               new Employee(){Id = 3, Name = "Sara", Age = 29, Salary = 20000},
            };
            Array.Sort(employees01, new Employee());
            foreach (Employee employee in employees01)
            {
                Console.WriteLine(employee);
            }
            #endregion
        }
    }
}
