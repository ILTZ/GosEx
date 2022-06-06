using System;
using System.Collections.Generic;

namespace _15
{
    public class Quest15
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



    internal class Program
    {
        static void Main(string[] args)
        {
            Quest15 q = new Quest15();
            q.Prog();
        }
    }
}
