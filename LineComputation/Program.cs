using System;

namespace LineComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComputation lineComputation = new LineComputation();
            double length1=lineComputation.LengthOfLine(30.0, 20.0, 50.0, 40.0);
            double length2= lineComputation.LengthOfLine(40.0, 25.0, 55.0, 45.0);
            Console.WriteLine("length of line 1:" + length1 + "and length of line2" + length2);
            if (length1.Equals(length2))
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
