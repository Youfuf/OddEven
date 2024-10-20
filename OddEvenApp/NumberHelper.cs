using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenApp
{
    public static class NumberHelper
    {
        public static bool IsEven(int number) => number % 2 == 0;

        public static bool IsOdd(int number) => !IsEven(number);
    }
}
