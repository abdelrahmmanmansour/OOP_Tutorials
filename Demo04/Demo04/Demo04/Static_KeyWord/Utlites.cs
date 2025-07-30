using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Static_KeyWord
{
    internal class Utlites
    {
        // Helper Class 
            // Static Attribute:
            public static double Pi = 3.14;
            private static double pi;

            // Static Constructor:
            static Utlites()
            {
                pi = 3.14;
            }
            // Static Method:
            public static double CmToEnsh(double cm)
            {
                return cm / 2.54;
            }

            // Static Propperty:
            public static double PI
            {
                get
                {
                    return 3.14;
                }
            }

            public static double PIpi
            {
                get
                {
                    return Pi;
                }
            }
        }
    }
