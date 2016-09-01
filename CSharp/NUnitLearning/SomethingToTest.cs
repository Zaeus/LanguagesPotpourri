using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnitLearning
{
    class SomethingToTest
    {
        public static int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }

        public static decimal Multiply(decimal val1, decimal val2)
        {
            return val1 * val2;
        }

        public static int Divide(int val1, int val2)
        {
            return val1 / val2;
        }

        public static decimal Divide(decimal val1, decimal val2)
        {
            return val1 / val2;
        }

        public static int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public static decimal Add(decimal val1, decimal val2)
        {
            return val1 + val2;
        }

        public static int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }

        public static decimal Subtract(decimal val1, decimal val2)
        {
            return val1 - val2;
        }

        public static int Modulo(int val1, int val2)
        {
            return val1 % val2;
        }

        public static decimal Modulo(decimal val1, decimal val2)
        {
            return val1 % val2;
        }

        public static decimal TimeConsumingMethod(decimal val1, decimal val2, decimal val3, decimal val4)
        {
            Thread.Sleep(1000);
            return Subtract(Modulo(val1, val2), Divide(val3, val4));
        }
    }
}
