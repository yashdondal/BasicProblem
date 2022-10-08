using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    public  class Factors
    {
        int n;
        public static void factors()
        {
            Console.WriteLine("enter any number");
             int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }
            if (n >= 2)
            {
                Console.WriteLine(n);
            }
        }

    }
}
