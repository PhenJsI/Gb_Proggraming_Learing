
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

int Prinity(int[]array)
{
    int count = array.Length;
    int index = 0;
    int result = 0;
    while (index < count)
    {
        if (array[index] % 2 == 0)
        {
            result++;
        }
        index++;
    }
    return result;

}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

int resultnumber = Prinity(arr);
Console.WriteLine("Количество четных чисел = "+resultnumber);