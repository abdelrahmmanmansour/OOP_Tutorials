using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Partial_KeyWord
{
    internal partial class Employee
    {
        // partial: I Can make many class Called Employee
        public int Id { get; set; }
    }
    internal partial class Employee
    {
        // partial: I Can make many class Called Employee
        public string Name { get; set; }
    }
}
