using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите размер массива");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];
Console.Clear();
bool flag = false;
while (flag == false)
{
    Console.WriteLine();
    Console.WriteLine("НАЧАТЬ НОВЫЙ ТЕСТ ИЛИ ПОВТОРИТЬ?(y/n)");
    string txt = Console.ReadLine();
    if (txt == "y") {
        InputMatrix(matrix);
        PrintMatrix(matrix); 
        ReleaseMatrix(matrix); }
    else flag = true;
}
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
    int[,] matrixNew = new int[matrix.GetLength(0)-1, matrix.GetLength(1) - 1];
    int indexI = -1;
    int indexJ = -1;
    int min = 9999;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexJ = j;
                indexI = i;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Строка которая будет убрана по индексу = " + indexI + " Столбец который будет убрат по индексу= " + indexJ);
    int tmpi = 0;
    int tmpj = 0;
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        if (i != indexI)
        {
            tmpj = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != indexJ)
                {
                    matrixNew[tmpi, tmpj] = matrix[i, j];
                    tmpj++;
                }
            }
            tmpi++;
        }
    }
    Console.WriteLine("Новый массив");
    for (int i = 0;i<matrixNew.GetLength(0); i++)
    {
        for(int j = 0; j < matrixNew.GetLength(1); j++)
        {
            Console.Write(matrixNew[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
