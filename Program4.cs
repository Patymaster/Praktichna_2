using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        delegate int StringLengthDelegate(string str);

        static void Main()
        {
            // Заповнення списку рядків
            List<string> strings = new List<string>();
            Console.WriteLine("Введіть рядки:");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "")
                {
                    break;
                }
                strings.Add(str);
            }

            // Створення делегата за допомогою лямбда-виразу
            StringLengthDelegate stringLengthDelegate = str => str.Length;

            // Обробка списку рядків за допомогою делегата
            Console.WriteLine("Довжини рядків:");
            foreach (var str in strings)
            {
                int length = stringLengthDelegate(str);
                Console.WriteLine($"{str}: {length}");
            }
        }
    }
}