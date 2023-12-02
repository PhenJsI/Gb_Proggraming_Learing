using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите размер массива");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Console.WriteLine("Введите позицию элементов. Подсказка: элементы начинаются с 0.");
int[] numbers = Console.ReadLine().Split(" ").Select(y => int.Parse(y)).ToArray();

int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindNumberMatrix(matrix, numbers);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 1110);
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
void FindNumberMatrix(int[,] matrix, int[]array)
{
    bool flag = false;
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == array[0] && j == array[1])
            {
                flag = true;
                Console.WriteLine("Искомое значение = "+ matrix[i,j]);
                break;
            }
        }
    }
    if (flag == false) 
    { 
        Console.WriteLine("Значение вне матрицы");
    }
}

