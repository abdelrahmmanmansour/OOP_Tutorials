using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01
{
    #region Enums
    // Create Enum For Gender:
    enum Gender
    {
        M,
        F,
        Male = 0,
        Female = 1,
    }

    // Create Enum For SecurityLevel:
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    #endregion
    internal class EmployeeP2
    {
        #region Attributes
        // Attributes:
        private int id;
        private string name;
        private Gender gender;
        private double salary;
        private DateTime hiringDate;
        private SecurityLevel securityLevel;
        #endregion
        #region Parametrized Constructor
        // Parametrized Constructor: 
        public EmployeeP2(int id, string name, Gender gender, SecurityLevel securityLevel, double salary, DateTime hiringDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HiringDate = hiringDate;
        }
        #endregion
        #region Apply Encapsulation[Using Full Property]
        // Apply Encapsulation[Using Full Property]:
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
        public Gender Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public double Salary
        {
            set
            {
                if (value > 2000)
                {
                    salary = value;
                }
            }
            get
            {
                return salary;
            }
        }
        public SecurityLevel SecurityLevel
        {
            set
            {
                securityLevel = value;
            }
            get
            {
                return securityLevel;
            }
        }
        public DateTime HiringDate
        {
            set
            {
                hiringDate = value;
            }
            get
            {
                return hiringDate;
            }
        }
        #endregion
        #region Method
        // Method: 
        public override string ToString()
        {
            //  (\n =< New Lie)
            return $"ID: {Id}\nName: {Name}\nGender: {Gender}\nSalary: {string.Format(new CultureInfo("en-US"), "{0:C}", Salary)}\nHiringDate: {HiringDate.ToString("dd/MM/yyyy")}\nSecurityLevel: {SecurityLevel}\n";
        }
        #endregion
    }
}
