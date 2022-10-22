using System;

namespace localclass5
{
    public static class localclas5
    {
        public static int[] RemoveNegativeNumbers(int[] array)
        {
            int lenght = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lenght++;
                }
            }
            int[] newarray = new int[lenght];

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    newarray[index] = array[i];
                    index++;
                }
            }

            return newarray;
        }
    }
}
