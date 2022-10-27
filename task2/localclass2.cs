using System;


namespace localclass2
{
    public static class localclas2
    {
        public static int[,,] GetArray(int minValue, int maxValue, int lenght1, int lenght2, int lenght3)
        {
            Random random = new Random();

            int[,,] array = new int[lenght1, lenght2, lenght3];

            for (int i = 0; i < lenght1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    for (int k = 0; k < lenght3; k++)
                    {
                        array[i, j, k] = random.Next(minValue, maxValue);
                    }
                }
            }

            return array;
        }
        public static void Print(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.WriteLine((i + 1) + ")");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("[" + array[i, j, k] + "]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void ChangeNumbers(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
