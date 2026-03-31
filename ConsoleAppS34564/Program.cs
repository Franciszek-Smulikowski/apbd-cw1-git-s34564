using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppS34564
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("    KALKULATOR STATYSTYCZNY      ");
            Console.WriteLine("=================================");
            Console.WriteLine("Podaj liczby całkowite oddzielone spacją lub przecinkiem:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Błąd: Wejście nie może być puste.");
                return;
            }

            string[] parts = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (parts.Length == 0)
            {
                Console.WriteLine("Błąd: Nie podano żadnych liczb.");
                return;
            }

            int[] numbers = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    Console.WriteLine($"Błąd: Wartość '{parts[i]}' nie jest poprawną liczbą całkowitą.");
                    return;
                }
            }

            int sum = StatisticsHelper.CalculateSum(numbers);
            double average = StatisticsHelper.CalculateAverage(numbers);
            int min = StatisticsHelper.CalculateMin(numbers);

            Console.WriteLine("\n--- OBLICZONE STATYSTYKI ---");
            Console.WriteLine($"Wczytane liczby: {string.Join(", ", numbers)}");
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"Średnia: {average}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine("----------------------------");
        }
    }
}
