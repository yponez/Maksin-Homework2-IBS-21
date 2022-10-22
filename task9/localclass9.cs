using System;

namespace localclass9
{
    public static class localclas9
    {
        public static bool RepeatNumberInArray(int i, int number, int[] array)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] EnterArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int element = 0;
                while (true)
                {
                    Console.Write($"Введите {i + 1} элемент: ");
                    if (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("Введена не цифра или число больше  " + int.MaxValue);
                        continue;
                    }
                    else if (RepeatNumberInArray(i, element, array))
                    {
                        Console.WriteLine("Элементы не должны повторяться");
                        continue;
                    }
                    array[i] = element;
                    break;
                }
            }

            return array;
        }

        public static bool IsSameArrays(int[] array, int[] newarray)
        {
            int[] Aray =    (int[])array.Clone();
            int[] newAray = (int[])newarray.Clone();

            Array.Sort(Aray);
            Array.Sort(newAray);

            for (int i = 0; i < newAray.Length; i++)
            {
                if (Aray[i] != newAray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

