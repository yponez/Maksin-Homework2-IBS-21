using System;
using Globalclass;
using localclass1;

const int lenght = 5;
const int minValue = 0;
const int maxValue = 10;


int[] myArray = Globalclas.GetArray(minValue, maxValue, lenght);
Console.WriteLine("Текущий массив");
Globalclas.Print(myArray);
Console.WriteLine("Отсортированный массив");
localclas1.Sortirovka(myArray);
Globalclas.Print(myArray);


Console.WriteLine("Минимальное значение:" + localclas1.GetMin(myArray));
Console.WriteLine("Максимальное значение:" + localclas1.GetMax(myArray));

