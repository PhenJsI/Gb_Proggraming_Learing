using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите размер массива");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Измененный массив:");
ReleaseMatrix(matrix);
PrintMatrix(matrix);
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
    int[] array = new int[matrix.GetLength(1)];
    
    for (int i = 0;i<matrix.GetLength(0); i++) 
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                array[j] = matrix[i, j];
                matrix[i,j] = matrix[matrix.GetLength(0)-1, j];
            }
            if (i == matrix.GetLength(0)-1)
            {
                matrix[i, j] = array[j];
            }
        }
    }
}

