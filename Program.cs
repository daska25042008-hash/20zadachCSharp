using System;
namespace Zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число больше 999:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sot = (n / 100) % 10;
            int tas = n / 1000;

            Console.WriteLine("Число сотен: " + sot);
            Console.WriteLine("Число тысяч: " + tas);
        }
    }
}
