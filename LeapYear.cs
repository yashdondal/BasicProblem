using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    internal class LeapYear
    {
       public static void CheckingLeap()
        {
            int year;
            Console.Write("Check whether a given year is leap year or not- \n");
            Console.Write("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4) == 0)
            {
                Console.WriteLine("It is a leap Year", year);
            }

            else
            {
                Console.WriteLine("It is not a leap year", year);
            }
        }
    }
}
