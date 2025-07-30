using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Img} i";
        }
        // Operator Overloading:
        // Function Must Be Public + Static(Can Call it by Class Direct[Not Create Object])
        #region 1- (+,- Operator)
        // 1- (+,- Operator) :
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex()
            {
                Real = (complex1?.Real ?? 0) + (complex2?.Real ?? 0),
                Img = (complex1?.Img ?? 0) + (complex2?.Img ?? 0)
            };
        }
        public static Complex operator -(Complex complex1, Complex complex2)
        {
            return new Complex()
            {
                Real = (complex1?.Real ?? 0) - (complex2?.Real ?? 0),
                Img = (complex1?.Img ?? 0) - (complex2?.Img ?? 0)
            };
        }
        #endregion
        #region 2- (++,-- Operator)
        // 2- (++,-- Operator):
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            return new Complex();
        }
        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            return new Complex();
        }
        #endregion
        #region 3- (Comparsion operator)
        // 3- (Comparsion operator):
        // Must Be bool
        public static bool operator >(Complex complex1, Complex complex2)
        {
            if (complex1.Real == complex2.Real)
            {
                return complex1.Img > complex2.Img;
            }
            return complex1.Real > complex2.Real;
        }
        public static bool operator <(Complex complex1, Complex complex2)
        {
            if (complex1.Real == complex2.Real)
            {
                return complex1.Img < complex2.Img;
            }
            return complex1.Real < complex2.Real;
        }
        public static bool operator >=(Complex complex1, Complex complex2)
        {
            if (complex1.Real == complex2.Real)
            {
                return complex1.Img >= complex2.Img;
            }
            return complex1.Real > complex2.Real;
        }
        public static bool operator <=(Complex complex1, Complex complex2)
        {
            if (complex1.Real == complex2.Real)
            {
                return complex1.Img <= complex2.Img;
            }
            return complex1.Real < complex2.Real;
        }
        public static bool operator ==(Complex complex1, Complex complex2)
        {
            return complex1.Real == complex2.Real && complex1.Img == complex2.Img;
        }
        public static bool operator !=(Complex complex1, Complex complex2)
        {
            return complex1.Real != complex2.Real || complex1.Img != complex2.Img;
        }
        #endregion
        #region User Defined Casting Operator(Manual Mapping):
        // User Defined Casting Operator(Manual Mapping): 
        // Convert complex to string
        // Better => explicit
        public static explicit operator string(Complex complex)
        {
            return complex.ToString();
        }
        public static implicit operator int(Complex complex)
        {
            return 12;
        }
        // Mapping: Convert from datatype to datatype

        #endregion
    }
}
