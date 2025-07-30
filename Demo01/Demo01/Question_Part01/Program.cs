namespace Question_Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1:
            #region 1. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them:
            // Create Array of Point2D
            //Point2D[] point2D = new Point2D[2];
            //double x, y;
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Please Enter Point {i + 1}: ");
            //    x = double.Parse(Console.ReadLine());
            //    y = double.Parse(Console.ReadLine());
            //    point2D[i] = new Point2D(x, y);
            //}
            //Point2D p = new Point2D();
            //Console.Write("The Distance Of Two Points is: ");
            //Console.WriteLine(p.Distance(point2D[0], point2D[1]));
            #endregion
            #region 2. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person:
            // Create Array of Person
            //Person[] person = new Person[3];
            //int age, max = int.MinValue;
            //string name;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Please Enter Person{i + 1}: ");
            //    age = int.Parse(Console.ReadLine());
            //    name = Console.ReadLine();
            //    person[i] = new Person(age, name);
            //}
            //Person p = new Person();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (person[i].Age > max)
            //    {
            //        max = person[i].Age;
            //        p = person[i];
            //    }
            //}
            //Console.WriteLine($"Age: {p.Age} Name: {p.Name}");
            #endregion

            // Part 2:
            #region 1. Design and implement a Class for the employees in a company:
            //EmplyoeeP2 emplyoeeP2 = new EmplyoeeP2(1, "Mansour", Gender.M, SecurityLevel.Guest, 12000, new DateTime(2002, 9, 21));
            //Console.WriteLine(emplyoeeP2.ToString());
            #endregion
            #region 2. Develop a Class to represent the Hiring Date Data:
            //HiringDate hiringDate = new HiringDate(2002, 9, 21);
            //Console.WriteLine(hiringDate.ToString());
            #endregion
            #region 3. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions:
            //EmplyoeeP2[] EmpArr = new EmplyoeeP2[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int id, year, month, day;
            //    string name;
            //    double salary;
            //    Gender gender;
            //    SecurityLevel securityLevel;
            //    DateTime dateTime;
            //    bool flag;
            //    do
            //    {
            //        Console.Write("Please Enter AN Integer ID: ");
            //        flag = int.TryParse(Console.ReadLine(), out id);
            //    } while (flag == false);
            //    do
            //    {
            //        Console.Write("Please Enter A Name: ");
            //        name = Console.ReadLine();
            //    } while (flag = name.Any(char.IsDigit)); // Avoid Numeric Names
            //    do
            //    {
            //        Console.Write("Please Enter A Salary: ");
            //        flag = double.TryParse(Console.ReadLine(), out salary);
            //    } while (flag == false);
            //    do
            //    {
            //        Console.Write("Please Enter A Gender: ");
            //        flag = Enum.TryParse(Console.ReadLine(), true, out gender);
            //    } while (flag == false);
            //    do
            //    {
            //        Console.Write("Please Enter A SecurityLevel: ");
            //        flag = Enum.TryParse(Console.ReadLine(), true, out securityLevel);
            //    } while (flag == false);
            //    Console.WriteLine("Please Enter A HiringDtae: ");
            //    do
            //    {
            //        Console.Write("Plaese Enter Valid Year: ");
            //        flag = int.TryParse(Console.ReadLine(), out year);
            //    } while (flag == false || year <= 0 || year > DateTime.Now.Year);
            //    do
            //    {
            //        Console.Write("Plaese Enter Valid Month: ");
            //        flag = int.TryParse(Console.ReadLine(), out month);
            //    } while (flag == false || month < 1 || month > 12);
            //    do
            //    {
            //        Console.Write("Plaese Enter Valid Day: ");
            //        flag = int.TryParse(Console.ReadLine(), out day);
            //    } while (flag == false || day < 1 || day > 31);
            //    EmpArr[i] = new EmplyoeeP2(id, name, gender, securityLevel, salary, new DateTime(year, month, day));
            //}
            //foreach (var Emp in EmpArr)
            //{
            //    Console.WriteLine(Emp);
            //}
            #endregion
        }
    }
}
