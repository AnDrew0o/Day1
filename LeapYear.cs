using System;

namespace ex1
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            return ((year % 100 != 0 && year % 4 == 0) || (year % 100 == 0 && year % 400 == 0));
        }

        static void Main(string[] args)
        {
            Console.Write("Ведiть рiк для перевiрки: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year) == true)
            {
                Console.WriteLine(year + " рiк - високосний");
            }
            else
            {
                Console.WriteLine(year + " рiк - не високосний");
            }
        }
    }
}
