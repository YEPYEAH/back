using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SQRT
{
    public class Calculator
    {
        public static string Calculate(double number, int accuracy)
        {
            var result = Math.Round(Math.Sqrt(Math.Abs(number)), accuracy).ToString();
            if (number < 0)
            {
                return result + "i";
            }
            return result;
        }
    }
}
