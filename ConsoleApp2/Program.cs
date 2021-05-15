using System;
using FizzBuzz;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            
            var output = fizzBuzz.DoFizzBuzz(5000);
            output.DecompressAndPrintToConsole();
        }
    }
}