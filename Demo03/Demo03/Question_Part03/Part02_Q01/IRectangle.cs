using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q01
{
    internal interface IRectangle  : IShape
    {
        // Signature Of Property:
        public double Width { get; set; }
        public double Length { get; set; }
    }
}
