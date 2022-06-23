// Напишите программу, которая будет 
// создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] ArrayOne = CreateFillArray();
PrintArray(ArrayOne);
int[] ArrayTwo = DuplicateArray(ArrayOne);
PrintArray(ArrayTwo);

int[] CreateFillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int[] DuplicateArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

