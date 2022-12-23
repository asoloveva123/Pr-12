//Вычислить сумму квадратов элементов последовательности
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            int a, S = 0;
            Console.Write("Сколько элементов в последовательности? ");
            n = Convert.ToUInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите целое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                S += a * a;
            }
            Console.WriteLine($"Сумма квадратов элементов последовательности S={S}");
            Console.ReadKey();
        }

    }
}
