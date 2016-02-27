﻿/*
   <summary>  
   TITLE              Harmonic series         Chapter4Exercise13.cs 
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Calculate the Harmonic number with
                      precision 3 digits after the decimal point.
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>27.02.2016</datecreated>
*/
using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter4Exercise13
    {
        static void Main()
        {
            // information
            Console.WriteLine("Find the Harmonic number.");
            double epsilon = 0.001;         // determines precision
            int term = 1;                   // summand
            double lastSum = 0;             
            double currentSum = 0;

            // accumulate sum
            int iterations = 0;
            while(true)
            {
                currentSum += (1.0 / term++);

                if (Math.Abs(currentSum - lastSum) < epsilon)
                {
                    break;
                }

                lastSum = currentSum;

                ++iterations;
            }  

            // print result
            Console.WriteLine("Current precision exceeded after {0} iterations, H = {1:F3}",
                              iterations, currentSum);
        }
    }
}