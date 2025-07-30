using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Employee
    {
        // Attributes: Kamal Case=> name,id,salary
        private int id;
        private string name;
        private double salary;
        // string Addrees => Automatic Property
        // Constructors:
        //public Employee()
        //{
        //    this.id = 1;
        //    this.salary = 0;
        //}
        //public Employee(int id, string name, double salary)
        //{
        //    // Validation
        //    SetID(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}
        #region Apply Encapsulation [Use Setter - Getter Methods]:
        // Apply Encapsulation [Use Setter - Getter Methods]:
        // Setter ID:
        //public void SetID(int id)
        //{
        //    this.id = id;
        //}
        //// Getter ID:
        //public int GetID()
        //{
        //    return this.id;
        //}
        //// Setter Name:
        //public void SetName(string name)
        //{
        //    if (name.Length >= 5 && name.Length <= 20)
        //    {
        //        this.name = name;
        //    }
        //}
        //// Getter Name:
        //public string GetName()
        //{
        //    return this.name;
        //}
        //// Setter Salary:
        //public void SetSalary(double salary)
        //{
        //    if (salary > 2000)
        //    {
        //        this.salary = salary;
        //    }
        //}
        //// Getter ID:
        //public double GetSalary()
        //{
        //    return this.salary;
        //} 
        #endregion
        #region Apply Encapsulation [Use Properties,Recommended]: Like Function
        // Apply Encapsulation [Use Properties,Recommended]: Like Function
        public Employee(int id, string name, double salary)
        {
            // Validation
            Id = id;
            Name = name;
            Salary = salary;
        }
        // 1. Full Property:
        // id:
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        // Name:
        public string Name
        {
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        // Salary:
        public double Salary
        {
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
            get
            {
                return salary;
            }
        }
        // 2. Automatic Property:
        // Syntax Sugur To Full Property + U Not Create A private Attribute
        public string Address
        {
            set; get;
        }
        // 3. Special Property[Indexer]: in PhoneBook Struct
        #endregion
        // Methods:
        public override string ToString()
        {
            return $"{id} {name} {salary} {Address}";
        }
    }
}
