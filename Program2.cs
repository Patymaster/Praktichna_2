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

                // Сортування співробітників за зарплатою
                var sortedEmployees = lines
                    .Select(line => new {
                        Name = line.Split(',')[0],
                        Salary = int.Parse(line.Split(',')[1])
                    })
                    .OrderBy(employee => employee.Salary);

                // Вивід
                Console.WriteLine("Sorted employees by salary:");
                foreach (var employee in sortedEmployees)
                {
                    Console.WriteLine($"{employee.Name}: {employee.Salary}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}