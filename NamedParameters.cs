using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class NamedParameters
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Value valiable a = " + a);
                Console.WriteLine("Value valiable b = " + b);
                Console.WriteLine("Value valiable result = " + result);
            }

            return result;
        }
        static void Main(string[] args)
        {
            int firstValue = 25;
            int lastValue = 40;
            int result = Sum(firstValue, lastValue, enableLogging: true);
        }
    }
}
