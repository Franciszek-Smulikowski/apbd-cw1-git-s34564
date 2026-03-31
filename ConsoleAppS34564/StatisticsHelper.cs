using System;

namespace ConsoleAppS34564
{
    public class StatisticsHelper
    {
        public static int CalculateSum(int[] values)
        {
            if (values == null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        public static double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta ani null.");
            }

            int sum = CalculateSum(values);
            return (double)sum / values.Length;
        }

        public static int CalculateMax(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta ani null.");
            }

            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }

        public static int CalculateMin(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta ani null.");
            }

            int min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }
    }
}
