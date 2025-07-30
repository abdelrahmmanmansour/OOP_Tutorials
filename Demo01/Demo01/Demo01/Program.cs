using System.Drawing;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            // Struct: Represent At Stack[Value Type]
            // When I Use Struct: New DataType 
            // When Data Have A Relationship With Each Other
            // It is preferable to a separate file
            // To Declare Object Or Variable From Struct:
            Point p01; // p01 is object at stack with 8 Bytes
            //Console.WriteLine(p01); // unassigned variable 'p01'
            p01 = new Point();
            p01.X = 12;
            p01.Y = 13;
            Console.WriteLine($"{p01.X} {p01.Y}"); // 12 13
            // new : Not For Create Object
            //     : Use To Select The Constructor
            p01 = new Point();
            Console.WriteLine($"{p01.X} {p01.Y}"); // 0 0
            p01 = new Point(12, 100);
            Console.WriteLine($"{p01.X} {p01.Y}"); // 12 100
            p01.PrintAttributes();
            //Console.WriteLine(p01.ToString()); == Console.WriteLine(p01);
            Console.WriteLine(p01); // Abdelrahman Mansour 
            #endregion
            #region OOP
            // OOP[Object Oreinted Programming]:
            // Style Of Programming,Not Programming Language
            // depends on Simulation Reality[Objects]
            // Best Paradiam To Build Any Business
            // Class: Bluprint Of The Object
            // Object: Spesific Instance Of Class
            // depends on 4 Fetures:
            // 1. Encapculation: فصل تعريف الداتا عن استخدامها
            // 2. Inheretance
            // 3. Polymorphism
            // 4. Abstraction 
            #endregion
            #region Encapsulation[Using Setter - Getter Methods]
            // Encapsulation[Using Setter - Getter Methods]
            // Apply On Class Or Struct
            // Seperate Data[Attributes] Definition From it Use
            //Employee em = new Employee();
            //em.id = 1;
            //em.name = "Entsar";
            //em.salary = 12000;
            //Console.WriteLine($"{em.id} {em.name} {em.salary}");
            // This is Problem:
            // 1. EndUser Access Data itself
            // 2. No Data Validation
            // 3. No Read Only Field
            // So Apply Encapsulation Solve all these:
            // 1. Make All Attributes Private
            // 2. Access Data Using:(Setters && Getters - Properties)
            // Setters && Getters:
            //em.SetID(1);
            //em.SetName("Ahmed");
            //em.SetSalary(12000);
            //Console.WriteLine($"{em.GetID()} {em.GetName()} {em.GetSalary()}");
            //Employee em01 = new Employee(2, "Mansour", 1500);
            //Console.WriteLine(em01); // 2 Mansour 0 
            #endregion
            #region Encapsulation[Properties,Recommended]
            // Encapsulation[Properties,Recommended]:
            // 1. Full Property:
            Employee em = new Employee(1,"Man",1200);
            Console.WriteLine(em);
            Employee em01 = new Employee(1, "Mansour", -2000);
            Console.WriteLine(em01);
            // 2. Automatic Property:
            em.Address = "Talka,Mansoura";
            Console.WriteLine(em);

            // Special Property[Indexer]:
            // Name: this
            PhoneBook phoneBook = new PhoneBook(3);
            phoneBook.AddUser("Abdelrahman Mansour", 11111, 0);
            phoneBook.AddUser("Mariam Mansour", 22222, 1);
            phoneBook.AddUser("Entsar Mansour", 33333, 2);
            Console.WriteLine(phoneBook.GetNumber("Abdelrahman Mansour"));
            phoneBook.UpdateUser("Abdelrahman Mansour", 1000);
            Console.WriteLine(phoneBook.GetNumber("Abdelrahman Mansour"));
            Console.WriteLine(phoneBook.GetName(33333));
            phoneBook.UpdateName(33333, "Mansour");
            Console.WriteLine(phoneBook.GetName(33333));

            //Indexer:
            Console.WriteLine(phoneBook["Mariam Mansour"]); // 22222  
            phoneBook["Mariam Mansour"] = 12000; // 
            Console.WriteLine(phoneBook["Mariam Mansour"]); // 12000

            Console.WriteLine(phoneBook[33333]);
            phoneBook[33333] = "Moha";
            Console.WriteLine(phoneBook[33333]);
            #endregion
            #region Class
            // Class: References[Heap]
            // NOTE: if i  create any type of Constructor then Delete Default Constructor
            Car c01 = new Car(1, "BMW", -2000);
            Console.WriteLine(c01);
            #endregion
            #region Struct VS Class
            // Struct VS Class:
            // 1. Struct : ValueType[Stack]
            //    Class  : ReferenceType[Heap]
            // 2. Struct : Not Accept Inheretance
            //    Class  : Accept Inheretance
            // 3. Struct : Not Delete Default Constructor
            //           : if i make Parameterless Constructor
            //    Class  : Delete Default Constructor
            //           : if i make Any Type Of Constructor 
            #endregion
        }
    }
}
