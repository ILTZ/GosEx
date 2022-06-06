using System;

namespace _12
{
    internal class Program
    {
        const int topEx = 50;
        const int botEx = 10;
        const int step = 5;

        const double fut = 3.281;

        static double getFuts(int _val)
        {
            return ((double)_val * fut);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица метры - футы");
            Console.WriteLine("Метры\t\tФуты");
            for (int i = botEx; i <= topEx; i += step)
            {
                Console.WriteLine($"{i}\t\t{getFuts(i)}");
            }
        }
    }
}
