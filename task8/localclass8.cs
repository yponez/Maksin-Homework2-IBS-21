using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localclass8
{
    public static class localclas8
    {
        public static void PrintSearchNumbers(int[] array)
        {
            Console.Write("Вывод искомых значений: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("(" + array[i] + ") ");
            }
        }
        public static int GetSearchNumber()
        {
            int findNum;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out findNum))
                {
                    Console.WriteLine("Введена не цифра или число больше  " + int.MaxValue);
                }
                break;
            }

            return findNum;
        }

        public static int[] GetIndexesOfSearchNumbers(int findNum, int[] array)
        {
            int length = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    length++;
                }
            }

            int[] indexes = new int[length];
            int ind = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == findNum)
                {
                    indexes[ind] = i;
                    ind++;
                }
            }

            return indexes;
        }
    }
}
