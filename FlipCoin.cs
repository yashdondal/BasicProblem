using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    internal class FlipCoin
    {
        public static void Percentage()
        {
            Console.WriteLine("Enter The Number of Flips");
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The random number Generated:" + number);

                    if (number == 0)
                    {
                        TailCount++;

                    }
                    else
                    {
                        HeadCount++;
                    }
                }
                Console.WriteLine("The count of Head is : " + HeadCount);
                Console.WriteLine("The Count of Tail is : " + TailCount);
            }
            else
            {
                Console.WriteLine("Please Enter Positive And greater than Zero");

            }
        }

    }
}
