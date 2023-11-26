
using System.Runtime.InteropServices;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,100);

        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++; 
    }
}

int NumberElem(int[] array)
{
    int count = array.Length;
    int index = 0;
    int elemCount = 0;
    while (index < count)
    {
        if (array[index] >=20 && array[index] <= 90) {
            elemCount++;
        }
        index++;
    }
    return elemCount;

}

int[] arr = new int[100];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

int countElem = NumberElem(arr);
Console.WriteLine(countElem);
