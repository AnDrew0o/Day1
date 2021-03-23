using System;

namespace ex3
{
    class Program
    {
        static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }


            return factorial;
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }
    }
}
