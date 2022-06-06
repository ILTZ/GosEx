using System;
using System.Collections.Generic;

namespace _16
{
    public class T16
    {
        public void Prog()
        {                
            int f = getNumerFromUser("Введите первый член прогрессии:");
            int topEx = getNumerFromUser("Введите количество членов прогрессии:");
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
        }

        private List<int> getProg(int _val, int _razn, int _topEx)
        {
            List<int> progr = new List<int>();
            int n = 1;
            while (n <= _topEx)
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


    internal class Program
    {
        static void Main(string[] args)
        {
            T16 task = new T16();
            task.Prog();
        }
    }
}
