// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Input array size.
Console.WriteLine("Программа создает массив со случайными числами, и находит количество четных чисел в нем.");
Console.Write("Укажите размер массива числом большим от нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

// Checking if "number" greater than zero.
while (number <= 0)
{
    Console.WriteLine("Ошибка ввода! введите другое число");
    number = Convert.ToInt32(Console.ReadLine());
}

// Array initialization.
int[] array = new int[number];

// Create a new void method for to fill an array.
void RandomFillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(1, 99);
    }
}

// Create a new void method for to print the array.
void PrintArray(int[] collection)
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

// Create a new void method for determining the number of even numbers.
void NumberEvenNumbers (int[] collection)
{
    int sum = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if ( collection[index] % 2 == 0)
        {
            sum++;
        }
    }

    Console.WriteLine("Количество счетных чисел в массиве: " + sum);
}

RandomFillArray(array);
PrintArray(array);
NumberEvenNumbers(array);