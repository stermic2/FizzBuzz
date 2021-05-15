using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string modThree { get; set; } = "Fizz";
        public string modFive { get; set; } = "Buzz";

        public FizzBuzz()
        {
            
        }
        public List<ulong> DoFizzBuzz(int iterations)
        {
            List<ulong> output = new List<ulong>();
            Console.WriteLine("Doing FizzBuzz:");
            for (int i = 0; i < iterations;)
            {
                ulong current = 0;
                for (int j = 0; j < 16 && i < iterations; j++)
                {
                    Console.Write("\r({0} of {1})", i, iterations);
                    current.Shift4BitsThenAdd('\n');
                    j++;
                    if (j == 16)
                    {
                        output.Add(current);
                        current = 0;
                        j = 0;
                    }
                    if(i % 3 == 0)
                        if (i % 5 == 0)
                            current.Shift4BitsThenAdd('z');
                        else current.Shift4BitsThenAdd('f');
                    else if (i % 5 == 0)
                        current.Shift4BitsThenAdd('b');
                    else
                        foreach (var character in i.ToString())
                            if (j >= 16)
                            {
                                output.Add(current);
                                current = (ulong) (character - '0');
                                j = 0;
                            }
                            else
                            {
                                current.Shift4BitsThenAdd(character);
                                j++;
                            }
                    i++;
                }
                output.Add(current);
            }
            return output;
        }
    }
}