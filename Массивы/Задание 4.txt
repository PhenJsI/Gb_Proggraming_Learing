using System;

int CountNumber(int arg)
{
    int lenghtNumber = 0;
    while (arg > 0)
    {
        lenghtNumber++;
        arg = arg / 10;
    }
    return lenghtNumber;

}

void FillArray(int[]array, int randomnumber)
{
    int index = 0;
    int count = array.Length;
    int diveder = randomnumber;

    while (index < count)
    {
        array[index] = diveder % 10;
        diveder /= 10;
        index++;
    }

}
void PrintArray(int[] array) {

    int count = array.Length;
    int index = 0;
    while (index < count)
    {

        Console.Write(array[index]+" ");
        index++;
    }
}

int randomnumber = 0;
Random random = new Random();
randomnumber = random.Next(0, 100000);
Console.WriteLine("Рандомное число равно = "+ randomnumber);
Console.WriteLine();
int lenght = CountNumber(randomnumber);
Console.WriteLine("Количество символов в числе = "+lenght);
Console.WriteLine();
int[] array = new int[lenght];
FillArray(array, randomnumber);
Array.Reverse(array);
Console.WriteLine("Итоговый массив:");
PrintArray(array);