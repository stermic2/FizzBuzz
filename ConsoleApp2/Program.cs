using System;
using FizzBuzz;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //The maximum value for this operation is MaxInt, but by my calculations; a good system would take about 24 hours to process such an operation.
            var output = FizzBuzz.FizzBuzz.DoFizzBuzz(5000);
            CompressionExtensions.modThree = "Fizzy";
            CompressionExtensions.modFive = "Buzzy";
            output.DecompressAndPrintToConsole();
        }
    }
}