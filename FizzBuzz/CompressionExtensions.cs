using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class CompressionExtensions
    {
        public static ulong Shift4BitsThenAdd(this ref ulong input, char character)
        {
            input <<= 4;
            input += Convert.ToByte(CompressionTable[character]);
            return input;
        }
        private static readonly Dictionary<char, byte> CompressionTable = new Dictionary<char, byte>()
        {
            {'x', 0},
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'0', 10},
            {'\n', 11},
            {'f', 12},
            {'b', 13},
            {'z', 14},
            {' ', 15}
        };

        public static void DecompressAndPrintToConsole(this List<ulong> input)
        {
            foreach (var number in input)
            {
                Console.Write(number.DecompressUlong());
            }
        }

        public static string DecompressUlong(this ulong number)
        {
            string output = "";
            output = output
                .ByteToChar(Convert.ToByte(number << 8 >> 60))
                .ByteToChar(Convert.ToByte(number << 12 >> 60))
                .ByteToChar(Convert.ToByte(number << 16 >> 60))
                .ByteToChar(Convert.ToByte(number << 20 >> 60))
                .ByteToChar(Convert.ToByte(number << 24 >> 60))
                .ByteToChar(Convert.ToByte(number << 28 >> 60))
                .ByteToChar(Convert.ToByte(number << 32 >> 60))
                .ByteToChar(Convert.ToByte(number << 36 >> 60))
                .ByteToChar(Convert.ToByte(number << 40 >> 60))
                .ByteToChar(Convert.ToByte(number << 44 >> 60))
                .ByteToChar(Convert.ToByte(number << 48 >> 60))
                .ByteToChar(Convert.ToByte(number << 52 >> 60))
                .ByteToChar(Convert.ToByte(number << 56 >> 60))
                .ByteToChar(Convert.ToByte(number << 60 >> 60));
            return output;
        }

        private static string ByteToChar(this string s, byte input)
        {
            char value;
            if (DecompressionTable.TryGetValue(input, out value) && value != 'x')
                s += value;
            return s;
        }
        
        private static readonly Dictionary<byte, char> DecompressionTable = new Dictionary<byte, char>()
        {
            {0, 'x'},
            {1, '1'},
            {2, '2'},
            {3, '3'},
            {4, '4'},
            {5, '5'},
            {6, '6'},
            {7, '7'},
            {8, '8'},
            {9, '9'},
            {10, '0'},
            {11, '\n'},
            {12, 'f'},
            {13, 'b'},
            {14, 'z'},
            {15, ' '}
        };
    }
}