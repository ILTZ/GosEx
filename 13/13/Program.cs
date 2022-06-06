using System;

namespace _13
{
    internal class Program
    {
        const int topEx = 10;
        const int botEx = 2;
        const double step = 0.5;

        const double yard = 1.094;

        static double getYards(double _val)
        {
            return ((double)_val * yard);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица метры - ярды");
            Console.WriteLine("Метры\t\tЯрды");
            for (double i = botEx; i <= topEx; i += step)
            {
                Console.WriteLine($"{i}\t\t{getYards(i)}");
            }
        }
    }
}
