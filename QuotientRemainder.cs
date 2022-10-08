using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    public static class QuotientRemainder
    {
     public static void CheckQuotient()
        {
            int r;
            int dividend = 40, divisor = 8;
            int quotient = dividend / divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}",dividend,divisor);
            Console.WriteLine("Qoutient = " + quotient);
            Console.WriteLine("Remainder = " + r);
            Console.ReadLine();
        }
    }

}
