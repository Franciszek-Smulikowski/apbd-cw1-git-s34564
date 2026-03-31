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
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Liczby: " + string.Join(", ", numbers));

            int sum = StatisticsHelper.CalculateSum(numbers);
            Console.WriteLine("Suma: " + sum);
        }
    }
}
