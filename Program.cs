using System;
namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд:");
            int n = Convert.ToInt32(Console.ReadLine());
            int часы = n / 3600;
            int минуты = (n / 60) % 60;
            int секунды = n % 60;

            Console.WriteLine("Полных часов прошло: " + часы);
            Console.WriteLine("Полных минут с начала часа: " + минуты);
            Console.WriteLine("Полных секунд с начала минуты: " + секунды);
        }
    }
}
