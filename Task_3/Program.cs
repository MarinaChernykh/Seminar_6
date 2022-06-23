// Напишите программу, которая будет 
// преобразовывать десятичное число 
// в двоичное.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] NewArray = CreateArray (number);
NewArray = FillArray (NewArray, number);
PrintArray (NewArray);


int[] CreateArray(int number)
{
    int size = 0;
    while (number != 0)
    {
        number = number / 2;
        size += 1;
    }
    
    int[] array = new int[size];
    return array;
}

int[] FillArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number = number / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



