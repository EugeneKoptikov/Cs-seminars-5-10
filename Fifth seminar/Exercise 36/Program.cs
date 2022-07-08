// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Input array size.
Console.WriteLine("Программа создает массив со случайными числами, и находит сумму нечетных элементов.");
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

// Create a new void method to sum odd element values.
void SumOddElements(int[] collection)
{
    int sum = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if (index % 2 == 0) sum += collection[index];
        // array[0] is first element (odd element),
        // array[1] is second element (even element) and so on...
    }
    Console.WriteLine("Сумма всех нечетных элементов массива: " + sum);
}       

RandomFillArray(array);
PrintArray(array);
SumOddElements(array);