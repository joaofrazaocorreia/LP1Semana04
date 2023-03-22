using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Print the powers of 2 until 2^5
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Print the powers of 2 until 2^n
        /// </summary>
        /// <param name="n">Maximum power of 2</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Main code
        /// </summary>
        /// <param name="args">Array of strings from the command line</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();

            PowersOf2UntilN(7);
            PowersOf2UntilN(2);
        }
    }
}
