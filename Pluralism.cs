using System;

namespace Ex2
{
    class Program
    {
        static string Pluralism(int count, string FirstForm, string SecondForm, string ThirdForm)
        {

            string countStr = Convert.ToString(count);

            int i = 0;

            do
            {
                if (count / 10 != 1)
                {
                    count = count % 10;
                }
                else
                {
                    count = count % 10;
                    count = count / 10;
                }
                i++;
            }
            while (i < countStr.Length - 1);

            if (count == 1)
            {
                return FirstForm;
            }
            else if (count <= 4 && count >= 2)
            {
                return SecondForm;
            }
            else
            {
                return ThirdForm;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введiть число i 3 варiанти слова (наприклад, 3 день днi днiв)");
            Console.Write("Число: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перша форма слова(день): ");
            string FirstForm = Console.ReadLine();
            Console.Write("Друга форма слова(днi): ");
            string SecondForm = Console.ReadLine();
            Console.Write("Третя форма слова(днiв): ");
            string ThirdForm = Console.ReadLine();

            Console.WriteLine(count + " " + Pluralism(count, FirstForm, SecondForm, ThirdForm));

            //перевiряв циклом

            /*
            for (int count = 0; count <= 127; count++)
            {
                Console.WriteLine(count + " " + Pluralism(count, FirstForm, SecondForm, ThirdForm));
            }
            */
        }
    }
}
