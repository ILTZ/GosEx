using System;

namespace _7
{
    internal class Program
    {
        static int getSum(int _digit)
        {
            int botVal = getBotVal(_digit);
            int sum = 0;
            for (int i = botVal; i < botVal * 10; ++i)
            {
                sum += i;
            }

            return sum;
        }

        static int getBotVal(int _digit)
        {
            int val = 1;
            while (_digit > 1)
            {
                val *= 10;
                --_digit;
            }

            return val;
        }


        static void Main(string[] args)
        {
            const int topEx = 4;
            const int botEx = 1;


            Console.WriteLine($"Введеите число 'n',удовлетворяющее  {botEx} <= n <= {topEx}");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма всех {x}-значных чисел: {getSum(x)}");


        }
    }
}
