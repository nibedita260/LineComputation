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
            Console.WriteLine("length of line1:" + length1 + "and length of line2:" + length2);
            if (length1.CompareTo(length2)==0)
            {
                Console.WriteLine("line1: "+length1 + "is equal to line2:"+ length2);
            }
            if (length1.CompareTo(length2)> 0)
            {
                Console.WriteLine("line1: "+length1 + "is greater than line2:" + length2);
            }
            if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("line1: "+length1 + "is less than line2:" + length2);
            }
        }
    }
}
