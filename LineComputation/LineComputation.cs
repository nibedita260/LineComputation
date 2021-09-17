using System;
using System.Collections.Generic;
using System.Text;

namespace LineComputation
{
    class LineComputation
    {
        public double LengthOfLine(double X1, double Y1, double X2, double Y2) // calculates the length of the line
        {
            Console.WriteLine("finding the length of line:");
            double x_total, y_total, total;
            x_total = X1 - X2;
            y_total = Y1 - Y2;
            total = Math.Sqrt((x_total * x_total) + (y_total * y_total));
            return total;              // length of the Line
        }
    }
}
