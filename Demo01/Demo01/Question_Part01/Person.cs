using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01
{
    internal struct Person
    {
        #region Attributes
        // Attributes:
        private int age;
        private string name;
        #endregion
        #region Parametrized Constructor
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        #endregion
        #region Apply Encapsulation[Using Full Property]
        // Apply Encapsulation[Using Full Property]:
        public int Age
        {
            set
            {
                if (value > 10)
                {
                    age = value;
                }
            }
            get
            {
                return age;
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

        #endregion
        #region Method
        // Method:
        public override string ToString()
        {
            return $"Age: {age} Name: {name}";
        }
        #endregion
    }
}
