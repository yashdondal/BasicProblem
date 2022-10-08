using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    internal class HarmonicNumbers
    {
        public static void Value()
        {
            int i, n;

            Console.WriteLine("Print The Harmonic Value");
            n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0}" + i);
                sum += 1 / (float)i;
            }
            Console.Write("\nsum of series upto {0} terms : {1} \n", n, sum);
        }

    }
}
