using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    public static class OddEven
    {
        public static void CheckOddEven()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine(i + " is even ");
            else
                Console.WriteLine(i + "is odd ");
            Console.ReadKey();   
        }
    }
}
