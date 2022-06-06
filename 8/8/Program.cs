using System;
using System.Collections.Generic;

namespace _8
{

    internal class Program
    {
        static int convertToDigit(int _val)
        {
            int ost = 0;
            List<int> l = new List<int>();

            while (_val > 0)
            {
                ost = _val % 2;
                _val /= 2;
                l.Add(ost);
            }

            return reverseList(ref l);
        }

        static int reverseList(ref List<int> _val)
        {
            int[] s = new int[_val.Count];
            for (int i = _val.Count - 1; i >= 0; --i)
            {
                s[_val.Count - 1 - i] = _val[i];
            }

            return Convert.ToInt32(string.Join("", s));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {x} в двоичной системе: {convertToDigit(x)}");
        }
    }
}
