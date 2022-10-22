using System;
using Globalclass;
using localclass6;


const int lenght = 5;
const int minValue = -10;
const int maxValue = 10;

int[] myArray = Globalclas.GetArray(minValue, maxValue, lenght);
Console.WriteLine("Массив до изменений");
Globalclas.Print(myArray);
myArray = localclas6.DoubleNegativeNumbers(myArray);
Console.WriteLine("Массив после изменений");
Globalclas.Print(myArray);