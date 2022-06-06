using System;
using System.Collections.Generic;

namespace _10
{
    internal class Program
    {
        static List<int> Prog(int _val, int _topEx, int _znam)
        {
            List<int> progr = new List<int>();
            int n = 1;
            while (n <= _topEx)
            {
                _val *= _znam;
                progr.Add(_val);

                ++n;
            }

            return progr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член прогрессии:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество членов прогрессии:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель прогрессии:");
            int z = Convert.ToInt32(Console.ReadLine());


            List<int> l = Prog(x, y, z);
            Console.WriteLine("Члены геометрической прогрессии:");
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
