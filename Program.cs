using System;
using static System.Console;


namespace RecursiveFactorialCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                if (Factorial(count) <= 999)
                {
                    Console.Write($"{count}! = {Factorial(count)}. To continue with {++count}! type anything but \"N\": ");
                }
                else
                {
                    Console.Write($"{count}! = {String.Format("{0:0,0}", Factorial(count))}. To continue with {++count}! type anything but \"N\": ");
                }

            } while (ReadLine().ToUpper() != "N");


        }

        public static double Factorial(int value)
        {
            if (value == 0) return 1;

            return value * Factorial(value - 1);
        }
    }
}
