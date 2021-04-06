using System;

namespace Optimization
{
    public class HalfDivisionMethod : IMethod
    {
        public Point GetMinimumValue(InputData inputs, Func<double, double, double> func)
        {
            double leftBorderA1 = inputs.leftBorderA1;
            double rightBorderA1 = inputs.rightBorderA1;
            double leftBorderA2 = inputs.leftBorderA2;
            double rightBorderA2 = inputs.rightBorderA2;
            double step = inputs.step;

            double minF = Double.MaxValue;
            double optimalA1 = 0;
            double optimalA2 = 0;

            double count = 0;

            while (step >= inputs.accuracy)
            {
                for (double A1 = leftBorderA1; A1 <= rightBorderA1; A1 += step)
                {
                    for (double A2 = leftBorderA2; A2 <= rightBorderA2; A2 += step)
                    {
                        if (++count == inputs.maxCount)
                            throw new CalculationMethodException("Превышено количество итераций");
                        if (4 * A1 + 5 * A2 <= 20)
                        {
                            var c = func(A1, A2);
                            if (c < minF)
                            {
                                minF = c;
                                optimalA1 = A1;
                                optimalA2 = A2;
                            }
                        }
                    }
                }

                leftBorderA1 = inputs.leftBorderA1 <= optimalA1 - step ? optimalA1 - step : leftBorderA1;
                rightBorderA1 = inputs.rightBorderA1 >= optimalA1 + step ? optimalA1 + step : rightBorderA1;
                leftBorderA2 = inputs.leftBorderA2 <= optimalA2 - step ? optimalA2 - step : leftBorderA2;
                rightBorderA2 = inputs.rightBorderA2 >= optimalA2 + step ? optimalA2 + step : rightBorderA2;
                step = step / 2;
            }
            if (minF == Double.MaxValue)
                throw new CalculationMethodException("Экстремум не найден");

            return new Point(optimalA1, optimalA2, func);
        }
    }
}
