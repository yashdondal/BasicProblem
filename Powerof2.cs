﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    public static class Powerof2
    {
        public static void PowerOfTwoSolution()
        {
            Console.WriteLine("Enter as 2^Number:- "); //Reading input from user
            string NNumber = Console.ReadLine();
            int number = Convert.ToInt32(NNumber);
            //convert from string into integer value
            int num = 1;
            //int i = 0;                // count from 0 to N
            //int powerOfTwo = 1;       // the ith power of two
            int i = 1;                // count from 0 to N
            int LimitPowerTwo = 31;
            // repeat until i equals n

            if (number > LimitPowerTwo)
            {
                Console.WriteLine($"You Enter {number}  of 2^ exceeds the value limit 31  ");// condition not equal to show message
            }

            else
            {


                for (i = 1; i <= number; i++) //to Check a number 
                {
                    num = (num * 2); // multiply number by 2
                    Console.WriteLine(num);
                }
            }
        }
    }
 }
