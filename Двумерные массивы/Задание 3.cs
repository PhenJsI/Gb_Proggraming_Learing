using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите размер массива");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];
Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0); i++)
    {
        for(int j = 0;j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    int [] sum = new int[matrix.GetLength(0)];
    for(int i=0; i < matrix.GetLength(0);i++)
    {
        
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i,j];
        }
    }
    Console.WriteLine("Сумма циф каждой строки : ");
    Console.WriteLine(string.Join(" ,",sum));
    int min = 999999;
    int index = 0;
    for (int i = 0;i<sum.Length;i++)
    {
        if (sum[i] < min) 
        {
            min = sum[i];
            index = i;
        }
    }
    Console.WriteLine("Строка с индексом "+index);
}


