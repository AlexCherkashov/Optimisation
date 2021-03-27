using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Value { get; private set; }
        public bool IsCorrect { get; private set; }

        private readonly Func<double, double, double> Func;

        public Point(double x, double y, Func<double, double, double> func)
        {
            X = x;
            Y = y;
            Value = func(x, y);
            IsCorrect = CheckCorrect(x, y);
            Func = func;
        }

        public void ChangePointToCorrect(List<Point> correctPoints)
        {
            double x = X;
            double y = Y;
            double sumX = correctPoints.Sum(point => point.X);
            double sumY = correctPoints.Sum(point => point.Y);

            while (!CheckCorrect(x, y))
            {
                x = 0.5 * (x + (sumX / correctPoints.Count));
                y = 0.5 * (y + (sumY / correctPoints.Count));
            }

            X = x;
            Y = y;
            Value = Func(x, y);
            IsCorrect = true;
        }

        public void ChangePointToCorrect(double Cx, double Cy)
        {
            double x = X;
            double y = Y;

            while (!CheckCorrect(x, y))
            {
                x = 0.5 * (x + Cx);
                y = 0.5 * (y + Cy);
            }

            X = x;
            Y = y;
            Value = Func(x, y);
            IsCorrect = true;
        }

        private bool CheckCorrect(double x, double y)
        {
            return 4 * x + 5 * y <= 20;
        }

        public void MoveToGood(Point goodPoint, double badValue)
        {
            double x = X;
            double y = Y;
            double value = Value;

            while (value > badValue)
            {
                x = 0.5 * (x + goodPoint.X);
                y = 0.5 * (y + goodPoint.Y);
                value = Func(x, y);
            }

            X = x;
            Y = y;
            Value = value;
            IsCorrect = CheckCorrect(x,y);
        }
    }
}
