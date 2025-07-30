using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part01
{
    internal class HiringDate
    {
        #region Attributes
        // Attributes:
        private int day;
        private int month;
        private int year;
        #endregion
        #region Parametrized Constructor
        // Parametrized Constructor: 
        public HiringDate(int year, int month, int day)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion
        #region Apply Encapsulation[Using Full Property]
        public int Year
        {
            set
            {
                if (value <= DateTime.Now.Year) // 2026 =< notvalid
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }

        }

        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
            }
            get
            {
                return month;
            }
        }


        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
            }
            get
            {
                return day;
            }
        }
        #endregion
        #region Method
        // Method:
        public override string ToString()
        {
            return new DateTime(Year, Month, Day).ToString("dd/MM/yyyy");
        }
        #endregion
    }
}
