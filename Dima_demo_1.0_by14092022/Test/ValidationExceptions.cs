using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Dima_demo_1_0_by14092022
{
    public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : base() { }
        public ValidationExceptions(string message) : base(message) { }
        public ValidationExceptions(string message, Exception ex) : base(message) { }
    }
}

