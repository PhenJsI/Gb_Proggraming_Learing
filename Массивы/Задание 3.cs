
using System;
using System.Runtime.InteropServices;

void FillArray(double[] collection)
{
    int length = collection.Length;
    Random random = new Random();
    int index = 0;
    while (index < length)
    {
        collection[index] = random.NextDouble() * 100;

        index++;
    }
}

void PrintArray (double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++; 
    }
}

double Difference(double[] array)
{
    int count = array.Length;
    int index = 0;
    double result = 0;
    double max = -100;
    double min = 9999;

    while (index < count)
    {
        if (array[index] > max) max = array[index]; 
        if (array[index] < min) min = array[index];
    index++;
    }
    Console.WriteLine("Максимальное число = "+max);
    Console.WriteLine();
    Console.WriteLine("Минимальное число = "+min);
    result = max - min;
    return result;

}

double [] arr = new double[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
double difference = Difference(arr);

Console.WriteLine();
Console.WriteLine("Разница между максимальным число и минимальным = "+difference);