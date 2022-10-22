using Globalclass;
using localclass9;


Console.Write("Введите размер массива: ");
int length = Globalclas.GetArrayLength();

int[] myArray1 = new int[length];
int[] myArray2 = new int[length];

Console.WriteLine("Заполнение первого массива");
myArray1 = localclas9.EnterArray(myArray1);

Console.WriteLine("Заполнение второго массива");
myArray2 = localclas9.EnterArray(myArray2);

if (localclas9.IsSameArrays(myArray1, myArray2))
{
    Console.WriteLine("Массивы одинаковы");
}
else
{
    Console.WriteLine("Массивы разные");
}

Globalclas.Print(myArray1);
Globalclas.Print(myArray2);