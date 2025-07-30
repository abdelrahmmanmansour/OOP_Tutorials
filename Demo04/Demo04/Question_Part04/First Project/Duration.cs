using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part04.First_Project
{
    internal class Duration
    {
        #region Make Three Automatic Property[These Create Three Attributes in DDL]
        // Make Three Automatic Property[These Create Three Attributes in DDL]:
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        // Constructors:
        // 1- Take Three Paramters:
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        // 2- Take One Paramters:
        public Duration(int total)
        {
            // total => total second
            Hours = total / 3600;  // (3600 => 60*60)
            int Remaider01 = total % 3600; // (Remaider01 => Remainder of Hours)
            Minutes = Remaider01 / 60;     // to get Minutes
            Seconds = Remaider01 % 60;     // to get Seconds
        }
        #endregion

        #region Method
        // Override ToString() Method:
        public override string ToString()
        {
            string output = "";
            if (Hours > 0)
            {
                output += $"Hours: {Hours} , ";
            }
            output += $"Minutes: {Minutes} , ";
            output += $"Seconds: {Seconds}";
            return output;
        }
        #endregion

        #region Operator Overloading
        // Operator Overloading: 
        // 1) D3 = D1 + D2:
        // The mechanism to add two Duration (hours*3600+minutes*60+seconds)
        private int DoSumTwoDuration()
        {
            // I Make this private to not anyone update in it
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        public static Duration operator +(Duration left, Duration right)
        {
            int Total = left.DoSumTwoDuration() + right.DoSumTwoDuration();
            return new Duration(Total);
        }

        // 2) D3 = D1 + 7800:
        public static Duration operator +(Duration left, int Number)
        {
            int Total = left.DoSumTwoDuration() + Number;
            return new Duration(Total);
        }

        // 3) D3 = 666 + D3:
        public static Duration operator +(int Number, Duration right)
        {
            int Total = Number + right.DoSumTwoDuration();
            return new Duration(Total);
        }

        // 4) D3 = ++D1 (Increase One Minute):
        public static Duration operator ++(Duration duration)
        {
            // why (+ 60) U told That
            int Total = duration.DoSumTwoDuration() + 60;
            return new Duration(Total);
        }

        // 5) D3 = --D2 (Decrease One Minute):
        public static Duration operator --(Duration duration)
        {
            // why (- 60) U told That
            int Total = duration.DoSumTwoDuration() - 60;
            return new Duration(Total);
        }

        // 6) D1 = D1 - D2:
        public static Duration operator -(Duration left, Duration right)
        {
            int Total = left.DoSumTwoDuration() - right.DoSumTwoDuration();
            return new Duration(Total);
        }

        // 7) If (D1>D2) => Comparision Operator:
        // Must Be Make (> <):
        public static bool operator >(Duration left, Duration right)
        {
            return left.DoSumTwoDuration() > right.DoSumTwoDuration();
        }
        public static bool operator <(Duration left, Duration right)
        {
            return left.DoSumTwoDuration() < right.DoSumTwoDuration();
        }
        #endregion
    }
}
