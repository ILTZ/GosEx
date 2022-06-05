using System;
using System.Collections.Generic;

namespace Quests
{
    //Создать программу на любом языке программирования:....



    //...Найти сумму всех n-значных числее (1 <= n <= 4)
    public class Quest7
    {
        const int topEx = 4;
        const int botEx = 1;


        public void Prog()
        {
            bool checkValue = false;

            while (!checkValue)
            {
                
                try
                {
                    int x = getNumerFromUser($"Введеите число 'n',удовлетворяющее  {botEx} <= n <= {topEx}");
                    if (x <= topEx && x >= botEx)
                    {
                        checkValue = true;
                    }
                    else
                    {
                        Console.WriteLine("Число не входит в заданный диапазон!");
                        continue;
                    }

                    Console.WriteLine($"Сумма всех {x}-значных чисел: {getSum(x)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Напишите корректное число!");
                    continue;
                }
            }

            
            

        }

        private int getSum(int _digit)
        {
            int botVal = getBotVal(_digit);
            int sum = 0;
            for (int i = botVal; i < botVal * 10; ++i)
            {
                sum += i;
            }

            return sum;
        }

        private int getBotVal(int _digit)
        {
            int val = 1;
            while (_digit > 1)
            {
                val *= 10;
                --_digit;
            }

            return val;
        }

        private int getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            return x;
        }
    }

    //...Составить программу перевода из натурального числа из десятичной в двоичную
    public class Quest8
    {

        public void Prog()
        {
            bool checkInput = false;

            while (!checkInput)
            {
                try
                {
                    int x = getNumerFromUser("Введите наутральное число:");
                    if (x < 0)
                    {
                        Console.WriteLine("Отрицательное число не может быть натуральным!");
                        continue;
                    }

                    Console.WriteLine($"Число {x} в двоичной системе: {convertToDigit(x)}");
                    checkInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введите натуральное число!");
                    continue;
                }
            }

        }

        private int convertToDigit(int _val)
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

        private int reverseList(ref List<int> _val)
        {
            int[] s = new int[_val.Count]; 
            for (int i = _val.Count - 1; i >= 0; --i)
            {
                s[_val.Count - 1 - i] = _val[i];
            }

            return Convert.ToInt32(string.Join("", s));
        }

        private int getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            return x;
        }
    }
        
    // Вывести члены арифметической прогрессии. Значение первого члена, разность и количество членов задаются (формула n-го члена:
    // an = a1 + d(n-1))
    public class Quest9
    {
        public void Prog()
        {
            bool checkUser = false;

            while (!checkUser)
            {
                try
                {
                    int f = getNumerFromUser("Введите первый член прогрессии:");
                    int topEx = getNumerFromUser("Введите количество членов прогрессии:");
                    if (topEx < 1)
                    {
                        Console.WriteLine("Количество членов не может быть меньше 1!");
                        continue;
                    }
                    int razn = getNumerFromUser("Введите разность:");

                    
                    List<int> l = getProg(f, razn, topEx);
                    Console.WriteLine("Члены прогрессии:");
                    for (int i = 0; i < l.Count; ++i)
                    {
                        if (i != 0 && i % 10 == 0)
                        {
                            Console.Write('\n');
                        }
                        Console.Write($"{l[i]},");
                    }

                    checkUser = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }
        }

        private List<int> getProg(int _val, int _razn, int _topEx)
        {
            List<int> progr = new List<int>();
            int n = 1;
            while (n < _topEx)
            {
                int tVal = _val + _razn * (n - 1);
                progr.Add(tVal);

                ++n;
            }

            return progr;
        }

        private int getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            return x;
        }
    }

    // Вывести члены геометрической прогрессии. Значение первого члена, разность и количество членов задаются (формула n-го члена:
    // bn = b1 * (q^(n-1))
    public class Quest10
    {

        public void Prog()
        {
            bool checkUser = false;

            while (!checkUser)
            {
                try
                {
                    int f = getNumerFromUser("Введите первый член прогрессии:");
                    int topEx = getNumerFromUser("Введите количество членов прогрессии:");
                    if (topEx < 1)
                    {
                        Console.WriteLine("Количество членов не может быть меньше 1!");
                        continue;
                    }
                    int znam = getNumerFromUser("Введите знаменатель:");


                    List<int> l = getProg(f, znam, topEx);
                    Console.WriteLine("Члены прогрессии:");
                    for (int i = 0; i < l.Count; ++i)
                    {
                        if (i != 0 && i % 10 == 0)
                        {
                            Console.Write('\n');
                        }
                        Console.Write($"{l[i]},");
                    }

                    checkUser = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }
        }

        private List<int> getProg(int _val, int _znam, int _topEx)
        {
            List<int> progr = new List<int>();
            int n = 1;
            while (n < _topEx)
            {
                _val *= _znam;
                progr.Add(_val);

                ++n;
            }

            return progr;
        }

        private int getUp(int _val, int _step)
        {
            while (_step > 1)
            {
                _val *= _val;
            }
            return _val;
        }


        private int getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            return x;
        }
    }


    // Составить таблицу квадратных корней от a до b с шагом 0.1.
    // Значения a и b задаются.
    public class Quest11
    {
        const double Step = 0.1;


        public void Prog()
        {
            bool checkInput = false;
            while (!checkInput)
            {
                try
                {
                    int a = getNumerFromUser("Введите нижнюю границу:");
                    int b = getNumerFromUser("Введите верхнюю границу:");

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


                    checkInput = true;
                }
                catch (Exception x)
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }

        }
        

        private double getSqrt(double _val)
        {
            return Math.Sqrt(_val);
        }



        private int getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            return x;
        }
    }

    // Составить таблицу переводов метров в футы на интервале от 10 до 50 метров с шагом
    // 5 (1 метр = 3,281 футов)
    public class Quest12
    {
        const int topEx = 50;
        const int botEx = 10;
        const int step = 5;

        public void Prog()
        {
            Console.WriteLine("Таблица метры - футы");
            Console.WriteLine("Метры\t\tФуты");
            for (int i = botEx; i <= topEx; i += step)
            {
                Console.WriteLine($"{i}\t\t{getFuts(i)}");
            }
        }



        const double fut = 3.281;
        private double getFuts(int _val)
        {
            return ((double)_val * fut);
        }


    }

    // Составить таблицу перевода метров в ярды на интервале от 2 до 10 метров с шагом
    // 0,5 (1 метр = 1,094 ярда)
    public class Quest13
    {
        const int topEx = 10;
        const int botEx = 2;
        const double step = 0.5;

        public void Prog()
        {
            Console.WriteLine("Таблица метры - ярды");
            Console.WriteLine("Метры\t\tЯрды");
            for (double i = botEx; i <= topEx; i += step)
            {
                Console.WriteLine($"{i}\t\t{getYards(i)}");
            }
        }



        const double yard = 1.094;
        private double getYards(double _val)
        {
            return ((double)_val * yard);
        }
    }

    // Суммы в P y.e. положена в банк. Ежегодный прирост составляет X процентов годовых.
    // Вывести стоимость капитала в конце каждого года. Первоначальная сумма, процент прироста и срок задаются.
    public class Quest14
    {
        public void Prog()
        {
            bool checkInput = false;
            while (!checkInput)
            {
                try
                {
                    double start = getNumerFromUser("Введите первоначальную сумму:");
                    double percents = getNumerFromUser("Введите процент прироста:");
                    double years = getNumerFromUser("Введите срок:");

                    if (start < 0)
                    {
                        Console.WriteLine("Стартовая сумма не может быть меньше 0!");
                        continue;
                    }
                    if (percents < 0)
                    {
                        Console.WriteLine("Процентная ставка не может быть меньше 0!");
                        continue;
                    }
                    if (percents < 0)
                    {
                        Console.WriteLine("Срок не может быть меньше 0!");
                        continue;
                    }

                    double temp = 0.0;
                    Console.WriteLine("Прирост за год\tСтоимость капитала\tгод");
                    for (int i = 0; i <= Convert.ToInt32(years); ++i)
                    {
                        // Я ебал, какой тут процент
                        // пусть будет простой
                        temp += (start * (percents / 100));
                        Console.WriteLine($"{temp}\t\t{start+temp}\t\t\t{i + 1}");
                    }

                    checkInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введите корректное значение!");
                    continue;
                }
            }
        }




        private double getNumerFromUser(string _message)
        {
            Console.WriteLine(_message);
            double x;
            x = Convert.ToDouble(Console.ReadLine());


            return x;
        }
    }

    // Вывести члены геометрической прогрессии. Значение первого члена, разность и количество членов задаются (формула n-го члена:
    // bn = b1 * (q^(n-1))
    public class Quest15
    {
        // См. Quest10
    }

    // Вывести члены арифметической прогрессии. Значение первого члена, разность и количество членов задаются (формула n-го члена:
    // an = a1 + d(n-1))
    public class Quest16
    {
        //  См. Quest9
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Quest7 q = new Quest7();
            //q.Prog();

            //Quest8 q = new Quest8();
            //q.Prog();

            //Quest9 q = new Quest9();
            //q.Prog();

            //Quest10 q = new Quest10();
            //q.Prog();

            //Quest11 q = new Quest11();
            //q.Prog();

            //Quest12 q = new Quest12();
            //q.Prog();

            //Quest13 q = new Quest13();
            //q.Prog();

            //Quest14 q = new Quest14();
            //q.Prog();

            //Quest15

            //Quest16


        }
    }
}
