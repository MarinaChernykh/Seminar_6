// Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

int[] Triangle = CreateFillTriangle();
PrintArray (Triangle);
TriangleCheck (Triangle);

int[] CreateFillTriangle()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите сторону {i + 1}: ");
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

void TriangleCheck (int [] array)
{
    if ((array[0] < array [1] + array [2]) && (array[1] < array [0] + array [2]) && (array[2] < array [0] + array [1]))
    {
        Console.WriteLine ("Треугольник");
    }
    
    else Console.WriteLine (" Не треугольник");
}

