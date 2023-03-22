using System;

namespace Lucas
{
    class Program
    {
        private static int Lucas(int n)
        {
            if (n==0)
            {
                int number = 1;
            }

            else if (n==1)
            {
                int number = 2;
            }

            else
            {
                int number = (n - 1) + (n - 2);
            }

            return number;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
