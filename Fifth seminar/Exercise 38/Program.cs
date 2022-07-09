// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Input array size.
Console.WriteLine("Программа создает массив со случайным набором вещественных чисел, и находит разницу между максимальным и минимальным значениями элементов в нем.");
Console.Write("Укажите размер массива числом большим от нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

// Checking if "number" greater than zero.
while (number <= 0)
{
    Console.WriteLine("Ошибка ввода! введите другое число");
    number = Convert.ToInt32(Console.ReadLine());
}

// Array initialization.
float[] array = new float[number];

// Create a new void method for to fill an array.
void RandomFillArray(float[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(1, 99);
    }
}

// Create a new void method for to print the array.
void PrintArray(float[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        if (index == 0)
        {
            Console.Write("[");
        }

        Console.Write(collection[index]);

        if (index < collection.Length - 1)
        {
            Console.Write(", ");
        }

        if (index == collection.Length - 1)
        {
            Console.WriteLine("]");
        }
        
        index++;       
    }
}

// Find the maximum element of the array.
float MaxElement(float[] collection)
{
    float max = collection[0];

    for (int index = 1; index < collection.Length; index++)
    {
        if (max < collection[index])
        {
            max = collection[index];
        }
    }

    return max;
}

// Find the minimum element of the array.
float MinElement(float[] collection)
{
    float min = collection[0];

    for (int index = 1; index < collection.Length; index++)
    {
        if (min > collection[index])
        {
            min = collection[index];
        }
    }

    return min;
}

RandomFillArray(array);
PrintArray(array);
Console.Write("Разница между элементом массива с максимальным значением и элементом с минимальным значением: " );
Console.Write(MaxElement(array) - MinElement(array));