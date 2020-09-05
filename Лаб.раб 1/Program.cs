using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб.раб_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_5 = 10, b = 5, y = 8;
            int Zxy;
            Zxy = a_5 + b - a_5 * (b + y);

            Console.WriteLine("Лабораторная работа №1. Разработка консольного приложения.");
            Console.WriteLine("Дергачева Ольга Вячеславовна");
            Console.WriteLine("ИНС-б-о-19-2(1), 09.03.02.");
            Console.WriteLine("09.12.2000.");
            Console.WriteLine("г. Ставрополь.");
            Console.WriteLine("Любимый предмет в школе - математика.");
            Console.WriteLine("Увлекаюсь фигурным катанием и пением.\n");

            Console.WriteLine("Решим выражение №30");
            Console.WriteLine("Zxy = a_5 + b - a_5 * (b+y)");
            Console.WriteLine("Переменная a_5 = {0}", a_5);
            Console.WriteLine("Переменная b = {0}", b);
            Console.WriteLine("Переменная y = {0}", y);
            Console.WriteLine("Ответ: Zxy = {0}", Zxy);
            Console.ReadKey();

        }
    }
}