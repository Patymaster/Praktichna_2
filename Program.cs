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

                // Фільтрування студентів за їх оцінками
                var filteredStudents = lines.Where(line =>
                {
                    int grade = int.Parse(line.Split(',')[1]);
                    return grade >= 60 && grade <= 100;//студенти з балом > 60
                });

                // Вивід
                Console.WriteLine("Filtered students:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}