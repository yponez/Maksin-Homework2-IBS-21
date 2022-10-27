using System;

namespace localclass3
{
    static public class localclas3
    {
        public static int SummNonNegativeNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
