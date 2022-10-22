namespace Globalclass
{
    static public class Globalclas
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + array[i] + "]");
            }
            Console.WriteLine();
        }

        public static int[] GetArray(int minValue, int maxValue, int ArrayLenght)
        {
            Random random = new Random();

            int[] array = new int[ArrayLenght];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }
        public static int GetArrayLength()
        {
            int length = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Введена не цифра или число больше " + int.MaxValue);
                }
                else if (length < 1)
                {
                    Console.WriteLine("Массив должен быть больше 0");
                }
                else
                {
                    break;
                }
            }
            return length;
        }
        public static int[] EnterArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int element = 0;
                while (true)
                {
                    Console.Write($"Введите {i+1} элемент: ");
                    if (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("Введена не цифра или число больше  " + int.MaxValue);
                        continue;
                    }
                    array[i] = element;
                    break;
                }
            }

            return array;
        }
    }
}