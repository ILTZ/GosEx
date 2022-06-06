using System;
using System.Collections.Generic;

namespace _9
{
    internal class Program
    {
        static List<int> getProg(int val, int razn, int gran)
        {
            List<int> progr = new List<int>();
            int n = 1;
            while (n <= gran)
            {
                int tVal = val + razn * (n - 1);
                progr.Add(tVal);

                ++n;
            }

            return progr;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член прогрессии:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество членов прогрессии:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите разность:");
            int razn = Convert.ToInt32(Console.ReadLine());

            List<int> l = getProg(first, razn, count);
            Console.WriteLine("Члены прогрессии:");
            for (int i = 0; i < l.Count; ++i)
            {
                if (i != 0 && i % 10 == 0)
                {
                    Console.Write('\n');
                }
                Console.Write($"{l[i]},");
            }

        }
    }
}
