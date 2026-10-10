using System;
namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random случайноеЧисло = new Random();
            Console.WriteLine(случайноеЧисло.Next(1, 1001));
            Console.WriteLine(случайноеЧисло.Next(1, 1001));
            Console.WriteLine(случайноеЧисло.Next(1, 1001));
            Console.WriteLine(случайноеЧисло.Next(1, 1001));
        }
    }
}
