using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization
{
    public class BoxMethod : IMethod
    {
        public Point GetMinimumValue(InputData inputs, Func<double, double, double> func)
        {
            var random = new Random();
            Point finalPoint;

            var points = GetPoints(inputs.leftBorderA1, inputs.leftBorderA2, inputs.rightBorderA1, inputs.rightBorderA2, func, inputs.maxCount);

            int countTry = 0;
            while (true)
            {
                points = points.OrderBy(point => point.Value).ToList();
                double sumX = points.Sum(point => point.X) - points[3].X;
                double sumY = points.Sum(point => point.Y) - points[3].Y;
                double Cx = sumX / 3;
                double Cy = sumY / 3;

                double B = 0.25 * ((Math.Abs(Cx - points[3].X) + Math.Abs(Cx - points[0].X)) +
                                   (Math.Abs(Cy - points[3].Y) + Math.Abs(Cy - points[0].Y)));
                if (inputs.accuracy > B)
                {
                    finalPoint = points[0];
                    break;
                }

                if (++countTry == inputs.maxCount)
                    throw new CalculationMethodException("Превышено количество итераций при поиске экстремума");

                double x0 = 2.3 * Cx - 1.3 * points[3].X;
                double y0 = 2.3 * Cy - 1.3 * points[3].Y;

                if (x0 > inputs.rightBorderA1) x0 = inputs.rightBorderA1 - inputs.accuracy;
                if (x0 < inputs.leftBorderA1) x0 = inputs.leftBorderA1 + inputs.accuracy;
                if (y0 > inputs.rightBorderA2) y0 = inputs.rightBorderA2 - inputs.accuracy;
                if (y0 < inputs.leftBorderA2) y0 = inputs.leftBorderA2 + inputs.accuracy;

                Point newPoint = new Point(x0, y0, func);
                if (!newPoint.IsCorrect)
                    newPoint.ChangePointToCorrect(Cx, Cy);

                if (newPoint.Value >= points[3].Value)
                    newPoint.MoveToGood(points[0], points[3].Value);
                points[3] = newPoint;
            }

            return finalPoint;
        }

        private static List<Point> GetPoints(double minX, double minY, double maxX, double maxY, Func<double, double, double> func, double maxCount)
        {
            int countTry = 0;
            var random = new Random();
            while (true)
            {
                var points = new List<Point>();
                for (int i = 0; i < 4; i++)
                {
                    double x = minX + random.NextDouble() * (maxX - minX);
                    double y = minY + random.NextDouble() * (maxY - minY);
                    points.Add(new Point(x, y, func));
                }

                var correctPoints = new List<Point>();
                var notCorrectPoints = new List<Point>();

                foreach (Point point in points)
                {
                    if (point.IsCorrect)
                        correctPoints.Add(point);
                    else notCorrectPoints.Add(point);
                }

                if (correctPoints.Count != 0)
                {
                    foreach (Point point in notCorrectPoints)
                    {
                        point.ChangePointToCorrect(correctPoints);
                        correctPoints.Add(point);
                    }
                    return correctPoints;
                }

                if (++countTry == maxCount)
                    throw new CalculationMethodException("Превышено количество итераций при генерации начальных точек");
            }
        }
    }
}
