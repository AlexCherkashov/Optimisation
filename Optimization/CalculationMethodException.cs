using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    class CalculationMethodException : Exception
    {
        public CalculationMethodException(string message) : base(message) { }
    }
}
