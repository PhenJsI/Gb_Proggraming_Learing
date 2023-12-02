int[] array = new int[10];
FillArray(array);
PrintArray(array);
int count = ReleaseArray(array);
Console.WriteLine("Количество четных чисел в массиве = "+ count);
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ,",array));
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0;i < array.Length;i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}