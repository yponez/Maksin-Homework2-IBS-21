﻿using System;

namespace localclass6
{
    public static class localclas6
    {
        public static int[] DoubleNegativeNumbers(int[] array)
        {
            int length = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    length++;
                }
            }

            int[] newarray = new int[array.Length + length];

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    newarray[index] = array[i];
                    newarray[index + 1] = array[i];
                    index++;
                }
                else
                {
                    newarray[index] = array[i];
                }
                index++;
            }

            return newarray;
        }
    }
}

