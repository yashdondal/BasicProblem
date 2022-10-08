using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodeProgram
{
    public static class SwapNumber
    {
        public static void SwapingNumber()
        {
            int a=5, b=10;

            Console.WriteLine("Before swap a = " + a + " b = " + b);

            a = a * b;
            b = a / b;  
            a = a / b;
            Console.WriteLine("After Swap a = " + a + " b = " + b ); 
        }
    }
}
