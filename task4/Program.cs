using System;
using Globalclass;
using localclass4;

const int lenght1 = 2;
const int lenght2 = 2;
const int minValue = -10;
const int maxValue = 10;

int[,] myArray = localclas4.GetArray(minValue, maxValue, lenght1, lenght2);
localclas4.Print(myArray);
Console.WriteLine("Сумма элементов на четных позициях = " + localclas4.SummNumbersInEvenPosition(myArray));
