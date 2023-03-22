using System;

namespace Lucas
{
    class Program
    {
        private static int Lucas(int n)
        {
            int number;

            if (n==0)
            {
                number = 2;
            }

            else if (n==1)
            {
                number = 1;
            }

            else
            {
                number = Lucas(n - 1) + Lucas(n - 2);
            }

            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Lucas(0));
            Console.WriteLine(Lucas(2));
            Console.WriteLine(Lucas(7));
        }
    }
}
