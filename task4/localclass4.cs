using System;

namespace localclass4
{
    public static class localclas4
    {
        public static int[,] GetArray(int minValue, int maxValue, int lenght1, int lenght2)
        {
            Random random = new Random();

            int[,] array = new int[lenght1, lenght2];

            for (int i = 0; i < lenght1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }

            return array;
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("[" + array[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
        public static int SummNumbersInEvenPosition(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }


}
