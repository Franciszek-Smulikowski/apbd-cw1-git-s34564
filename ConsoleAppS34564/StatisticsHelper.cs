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
    }
}
