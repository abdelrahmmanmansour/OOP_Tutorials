using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class PhoneBook
    {
        //  Attributes:
        string[] names;
        long[] numbers;
        // Constructors:
        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }
        // Indexer Property:
        public long this[string name]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1;
            }
        }
        public string this[long Number]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == Number)
                    {
                        names[i] = value;
                    }
                }
            }
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == Number)
                    {
                        return names[i];
                    }
                }
                return " ";
            }
        }
        // Methods:
        public void AddUser(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;
        }
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }
        public void UpdateUser(string name, long NewNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = NewNumber;
                }
            }
        }

        public string GetName(long Number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == Number)
                {
                    return names[i];
                }
            }
            return "";
        }
        public void UpdateName(long Number, string NewName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == Number)
                {
                    names[i] = NewName;
                }
            }
        }
    }
}
