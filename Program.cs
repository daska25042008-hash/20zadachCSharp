using System;
using System.Threading;

namespace Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Как тебя зовут?");
            string имя = Console.ReadLine()!;

            Console.WriteLine("Привет, " + имя + "!");

            Console.WriteLine("Ты знаешь что-нибудь о Тайной комнате?");
            Console.WriteLine("Да");

            Console.WriteLine("Можешь рассказать?");
            Console.WriteLine("Нет");

            Thread.Sleep(5000);

            Random случайноеЧисло = new Random();
            int цвет = случайноеЧисло.Next(1, 16);

            Console.ForegroundColor = (ConsoleColor)цвет;
            Console.WriteLine("Но могу показать");

            Console.ResetColor();
        }
    }
}

