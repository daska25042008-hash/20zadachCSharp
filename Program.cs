using System;
namespace Zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random случайноеЧисло = new Random();
            int[] цифры = new int[12];

            Console.Write("а) Случайный штрихкод: ");

            for (int i = 0; i < 12; i++)
            {
                цифры[i] = случайноеЧисло.Next(0, 10);
                Console.Write(цифры[i]);
            }

            int сумма = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    сумма = сумма + цифры[i];
                }
                else
                {
                    сумма = сумма + цифры[i] * 3;
                }
            }

            int контрольнаяЦифра = (10 - сумма % 10) % 10;

            Console.WriteLine(контрольнаяЦифра);

            Console.WriteLine("б) Введите первые 12 цифр штрихкода:");
            string штрихкод = Console.ReadLine()!;

            if (штрихкод.Length != 12)
            {
                Console.WriteLine("Ошибка! Нужно ввести ровно 12 цифр.");
                return;
            }

            сумма = 0;

            for (int i = 0; i < 12; i++)
            {
                int цифра = штрихкод[i] - '0';

                if (i % 2 == 0)
                {
                    сумма = сумма + цифра;
                }
                else
                {
                    сумма = сумма + цифра * 3;
                }
            }

            контрольнаяЦифра = (10 - сумма % 10) % 10;

            Console.WriteLine("Контрольная цифра: " + контрольнаяЦифра);
            Console.WriteLine("Полный штрихкод: " + штрихкод + контрольнаяЦифра);
        }
    }
}

