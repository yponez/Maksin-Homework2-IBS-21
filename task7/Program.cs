using System;
using Globalclass;
using localclass7;

Console.WriteLine("Веедите размер массива");
int n = Globalclas.GetArrayLength();
int[] myArray = new int[n];


myArray = Globalclas.EnterArray(myArray);
Console.WriteLine("Массив до сортировки");
Globalclas.Print(myArray);

localclas7.ReverseSortArray(myArray);

Console.WriteLine("Массив после сортировки");
Globalclas.Print(myArray);