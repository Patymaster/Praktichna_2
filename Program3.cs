using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть шлях до файлу");
            string path = Console.ReadLine();
            try
            {
                string[] lines = File.ReadAllLines(path);

                // Групування продуктів за ціною
                var groupedProducts = lines
                    .Select(line => new {
                        Name = line.Split(',')[0],
                        Price = int.Parse(line.Split(',')[1])
                    })
                    .GroupBy(product => product.Price);

                // Вивід
                Console.WriteLine("Grouped products by price:");
                foreach (var group in groupedProducts)
                {
                    Console.WriteLine($"Price: {group.Key}");
                    foreach (var product in group)
                    {
                        Console.WriteLine($"\t{product.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}