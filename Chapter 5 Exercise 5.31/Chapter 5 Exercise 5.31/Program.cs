//Bryan Racic, Evan Tellep
//9/8/16
//Bill Nicholson, Stack Overflow, http://www.exploringbinary.com/binary-converter/
//Build a Test case for our peers to build a Decimal Equivalent of a Bianary Number Class 
// Fifth Edition, Page 186. Chapter 5, Exercise 5.31
// Decimal Equivalent of a binary number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Exercise_5_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean passTest;
            String expectedResult;
            String test;

            //Basic Given Test, no Radix Point
            test = "1000011";
            if ((new Program().GetDecimalEquivalent(test)) == 67)
                Console.WriteLine("Test " + "(" + test + ") Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            else
                Console.WriteLine("Test " + "(" + test + ") Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 67);
            //Basic Given Test, no Radix Point
            test = "1111111111111111";
            if ((new Program().GetDecimalEquivalent(test)) == 65535)
                Console.WriteLine("Test " + "(" + test + ") Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            else
                Console.WriteLine("Test " + "(" + test + ") Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 65535);
            //Tests if Class handles overflow, inputs Max Of Long
            test = "1000000000000000000000000000000000000000000000000000000000000000";
            if ((new Program().GetDecimalEquivalent(test)) == 9223372036854775808)
                Console.WriteLine("Long Max Test Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            if ((new Program().GetDecimalEquivalent(test)) < 1)
                Console.WriteLine("Long Max Test Failed: " + (new Program().GetDecimalEquivalent(test)) + "-Overflow Error");
            else
                Console.WriteLine("Long Max Test Failed: " + (new Program().GetDecimalEquivalent(test)));

            //Tests if Class can compute Bianary with a Radix Point
            test = "10101.0101";
            if ((new Program().GetDecimalEquivalent(test)) == 10.3125)
                Console.WriteLine("Test " + "(" + test + ") Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            else
                Console.WriteLine("Test " + "(" + test + ") Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 10.3125);

            //Tests if Class can compute Bianary with a Radix Point
            test = "11111.0001";
            if ((new Program().GetDecimalEquivalent(test)) == 31.0625)
                Console.WriteLine("Test " + "(" + test + ") Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            else
                Console.WriteLine("Test " + "(" + test + ") Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 31.0625);

            //Tests if Class can compute Bianary with a Radix Point
            test = "1001101011001.10001101110110111";
            if ((new Program().GetDecimalEquivalent(test)) == 4953.55413055419921875)
                Console.WriteLine("Test " + "(" + test + ") Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            else
                Console.WriteLine("Test " + "(" + test + ") Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 4953.55413055419921875);

            //Tests if Class handles characters within expected long only string
            //If unhandled the class usually treats the character as a 0
            test = "1a100010.01010";
            if ((new Program().GetDecimalEquivalent(test)) == 98.3125)
                Console.WriteLine("Syntax Test Passed! Your Decimal Was:" + (new Program().GetDecimalEquivalent(test)));
            if ((new Program().GetDecimalEquivalent(test)) == 162.3125)
                Console.WriteLine("Syntax Test Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Didn't check syntax");
            else
                Console.WriteLine("Syntax Test Failed: " + (new Program().GetDecimalEquivalent(test)) + " -Expected Result:" + 98.3125);


        }
        /// <summary>
        /// Convert a binary number to a decimal number
        /// </summary>
        /// <param name="binaryNumber">The binary number to be converted</param>
        /// <returns>The decimal equivalent of binaryNumber</returns>
        public double GetDecimalEquivalent(String binaryNumber)
        {
            double result = 0;
            long bit = 1;
            int i = binaryNumber.Length - 1;
            while (i >= 0)
            {
                if (binaryNumber.Substring(i, 1).Equals("1"))
                {
                    result += bit;
                }
                bit *= 2;
                i--;
            }
            return result;
        }
    }
}
