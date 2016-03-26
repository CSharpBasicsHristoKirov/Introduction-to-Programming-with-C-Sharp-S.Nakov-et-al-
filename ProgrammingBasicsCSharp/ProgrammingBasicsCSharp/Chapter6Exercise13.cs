﻿/*
   <summary>     
   TITLE              Binary to decimal       Chapter6Exercise13.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Write a program that converts a number from
                      binary to decinal representation. 
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>07.03.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter6Exercise13
    {
        /*
            Method: int dec = binaryToDecimal(binary);

            It converts the string parameter consisted
            of binary represented number to decimal
            representation.
        */
        static int binaryToDecimal(string binary)
        {
            int dec = 0;

            // sum from right to left
            int length = binary.Length;
            for (int i = length - 1, exp = 0; i >= 0; i--, ++exp)
            {
                // accumulate the sum of the set bits
                if (binary[i] == '1')
                {
                    // raise the base (i.e. 2) by the power of the bit position
                    dec += (int)Math.Pow(2, exp);
                }
            }
            return dec;
        }
        //==============================================================================

        static void Main()
        {
            Console.WriteLine("Type a number in binary representation:");
            string binary = Console.ReadLine();

            Console.WriteLine("{0} in decimal is {1}", binary, binaryToDecimal(binary));
        }
    }
}
