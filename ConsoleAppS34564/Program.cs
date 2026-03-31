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
            Console.WriteLine("Podaj liczby całkowite oddzielone spacją lub przecinkiem:");
            string input = Console.ReadLine();

            string[] parts = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("Wczytane liczby: " + string.Join(", ", numbers));
            int sum = StatisticsHelper.CalculateSum(numbers);
            Console.WriteLine("Suma: " + sum);
        }
    }
}
