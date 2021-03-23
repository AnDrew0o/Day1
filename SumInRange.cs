using System;

namespace ex4
{
    class Program
    {
        static int SumIntRange(int num1, int num2)
        {
            int numMin = 0;
            int numMax = 0;
            int sum = 0;

            if (num1 > num2)
            {
                numMax = num1;
                numMin = num2;
            }
            else if (num1 < num2)
            {
                numMax = num2;
                numMin = num1;
            }
            else //num1 = num2
            {
                sum = num1;
            }

            for(int i = numMin; i <= numMax; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumIntRange(num1, num2));

            //Console.WriteLine(SumIntRange(1, 3));
            //Console.WriteLine(SumIntRange(5, 10));
            //Console.WriteLine(SumIntRange(10, 10));
        }
    }
}
