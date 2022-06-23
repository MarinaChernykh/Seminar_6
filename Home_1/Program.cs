// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] NewArray = CreateFillArray();
PrintArray(NewArray);
PositiveCounter(NewArray);

int[] CreateFillArray()
{
    Console.Write("Введите размер массива (M): ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void PositiveCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    Console.WriteLine($"Кол-во положительных чисел = {count}");
}

