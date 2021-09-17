using System;

namespace LineComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComputation lineComputation = new LineComputation();
            Console.WriteLine("The length of line: " + lineComputation.LengthOfLine(30.0, 20.0, 50.0, 40.0));
        }
    }
}
