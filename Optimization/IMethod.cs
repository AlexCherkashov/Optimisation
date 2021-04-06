using System;

namespace Optimization
{
    interface IMethod
    {
        Point GetMinimumValue(InputData inputs, Func<double, double, double> func);
    }
}
