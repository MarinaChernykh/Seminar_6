// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет
// на первом месте, а первый - на последнем и т.д.)


int[] ArrayOne = CreateFillArray();
PrintArray(ArrayOne);
int[] ArrayTwo = UpdateArray(ArrayOne);
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

int[] UpdateArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[array.Length - 1-i];
    }
    return result;
}

