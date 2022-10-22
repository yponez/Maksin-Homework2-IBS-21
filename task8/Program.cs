using Globalclass;
using localclass8;

const int minValue = 0;
const int maxValue = 10;
int length = 0;

Console.Write("Введите размер массива: ");
length = Globalclas.GetArrayLength();

int[] myArray = Globalclas.GetArray(minValue, maxValue, length);
Globalclas.Print(myArray);

Console.Write("\nВведите искомое число: ");
int findNum = localclas8.GetSearchNumber();

int[] indexes = localclas8.GetIndexesOfSearchNumbers(findNum, myArray);

if (indexes.Length == 0)
{
    Console.Write("Нет вхождений числа ("+findNum+")");
}
else
{
    localclas8.PrintSearchNumbers(indexes);
}