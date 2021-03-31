using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMenthod
{
    class Numbers
    {

        public int FindMinimum(int number1, int number2)
        {
            int number = Math.Min(number1, number2);
            return number;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            int number = (int)Math.Min(number1, Math.Min(number2, number3));
            return number;
        }
        public int FindMaximum(int number1, int number2)
        {
            int number = Math.Max(number1, number2);
            return number;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int number = (int)Math.Max(number1, Math.Max(number2, number3));
            return number;
        }
    }
}
