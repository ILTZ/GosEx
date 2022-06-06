using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод дробных чисел - через запятую

            Console.WriteLine("Введите первоначальную сумму:");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент прироста:");
            double percents = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите срок:");
            double years = Convert.ToDouble(Console.ReadLine());

            double temp = 0.0;
            Console.WriteLine("Прирост за год\tСтоимость капитала\tгод");
            for (int i = 0; i < Convert.ToInt32(years); ++i)
            {

                temp += (start * (percents / 100));
                Console.WriteLine($"{temp}\t\t{start + temp}\t\t\t{i + 1}");
            }

        }
    }
}
