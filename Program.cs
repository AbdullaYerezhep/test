using System;

namespace home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            static void bigger(int a, int b)
            {
                if (a < b)
                {
                    Console.WriteLine("Bigger one - {0}", b);
                }

                if (b < a)

                {
                    Console.WriteLine("Bigger one - {0}", a);
                }

                if (a == b)
                {
                    Console.WriteLine("Bigger one - {0}, but equal.", a);
                }
            }
            bigger(1, 2);
            bigger(1230, 12451);
            bigger(1, 1);
        }
    }
}
