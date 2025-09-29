using System;
using Lab2Lib;

namespace Lab2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість процесорів: ");
            int cntProcessors = int.Parse(Console.ReadLine());
            Processor[] arrProcessors = new Processor[cntProcessors];

            for (int i = 0; i < cntProcessors; i++)
            {
                Console.WriteLine($"\n--- Введення даних для процесора #{i + 1} ---");

                Console.Write("Бренд: ");
                string sBrand = Console.ReadLine();

                Console.Write("Модель: ");
                string sModel = Console.ReadLine();

                Console.Write("Покоління: ");
                int sGeneration = int.Parse(Console.ReadLine());

                Console.Write("Частота (ГГц): ");
                double sFrequency = double.Parse(Console.ReadLine());

                Console.Write("Кількість ядер: ");
                int sCores = int.Parse(Console.ReadLine());

                Console.Write("Вбудована графіка? (Y - так, N - ні): ");
                ConsoleKeyInfo keyGraphics = Console.ReadKey();
                Console.WriteLine();

                Console.Write("Рік випуску: ");
                int sYear = int.Parse(Console.ReadLine());

                Console.Write("Обсяг кешу (МБ): ");
                int sCache = int.Parse(Console.ReadLine());

                Processor proc = new Processor();
                proc.Brand = sBrand;
                proc.Model = sModel;
                proc.Generation = sGeneration;
                proc.Frequency = sFrequency;
                proc.Cores = sCores;
                proc.HasGraphics = keyGraphics.Key == ConsoleKey.Y ? true : false;
                proc.Year = sYear;
                proc.CacheSize = sCache;

                arrProcessors[i] = proc;
            }

            Console.WriteLine("\n--- Інформація про процесори ---");
            foreach (Processor p in arrProcessors)
            {
                Console.WriteLine();
                Console.WriteLine($"Дані про процесор {p.Model}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Бренд: " + p.Brand);
                Console.WriteLine("Модель: " + p.Model);
                Console.WriteLine("Покоління: " + p.Generation);
                Console.WriteLine("Частота (ГГц): " + p.Frequency.ToString("0.00"));
                Console.WriteLine("Кількість ядер: " + p.Cores);
                Console.WriteLine(p.HasGraphics ? "Процесор має вбудовану графіку." : "Процесор не має вбудованої графіки.");
                Console.WriteLine("Рік випуску: " + p.Year);
                Console.WriteLine("Розмір кешу (МБ): " + p.CacheSize);
                Console.WriteLine($"Продуктивність: {p.CalculatePerformance():0.00}");
            }

            Console.ReadKey();
        }
    }
}
