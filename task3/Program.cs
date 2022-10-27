using System;
using Globalclass;
using localclass3;

const int lenght = 5;
const int minValue = -100;
const int maxValue = 100;


int[] myArray = Globalclas.GetArray(minValue, maxValue, lenght);
Globalclas.Print(myArray);
Console.WriteLine("Сумма неотрицательных чисел массива = " + localclas3.SummNonNegativeNumbers(myArray));