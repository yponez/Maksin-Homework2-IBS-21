using System;
using Globalclass;
using localclass5;


const int lenght = 5;
const int minValue = -3;
const int maxValue = 3;

int[] myArray = Globalclas.GetArray(minValue, maxValue, lenght);
Console.WriteLine("Массив до изменений");
Globalclas.Print(myArray);
myArray = localclas5.RemoveNegativeNumbers(myArray);
Console.WriteLine("Массив после изменений");
Globalclas.Print(myArray);