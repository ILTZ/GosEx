using System;

namespace _11
{
    internal class Program
    {
        const double Step = 0.1;
        static double getSqrt(double _val)
        {
            return Math.Sqrt(_val);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введите нижнюю границу:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t_______________");
            Console.WriteLine("\tТаблица корней:");
            Console.WriteLine("Число \t\t\t Корень");
            for (double i = a; i <= b; i += Step)
            {
                if (i < 0)
                {
                    Console.WriteLine($"{i} \tNone.");
                    continue;
                }
                else if (Convert.ToInt32(i) == 0)
                    continue;

                Console.WriteLine($"{(i)} \t{getSqrt(i)}");
            }
        }
    }
}
