using System;
using localclass2;

const int lenght1 = 5;
const int lenght2 = 5;
const int lenght3 = 5;
const int MinValue = -10;
const int MaxValue = 10;


int[,,] myArray = localclas2.GetArray(MinValue, MaxValue, lenght1, lenght2, lenght3);
Console.WriteLine("Первоначальный массив");
localclas2.Print(myArray);
localclas2.ChangeNumbers(myArray);
Console.WriteLine("Массив после изменения");
localclas2.Print(myArray);