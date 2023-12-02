int[] array = new int[10];
FillArray(array);
PrintArray(array);
ReleaseArray(array);
Console.WriteLine("Изменненый массив:");
PrintArray(array);
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
void ReleaseArray(int[] array)
{
    int tmp = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length -  1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}