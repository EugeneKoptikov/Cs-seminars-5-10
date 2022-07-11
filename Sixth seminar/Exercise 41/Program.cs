// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Input number of values.
Console.WriteLine("Укажите количество чисел, которое собираетесь ввести.");
Console.Write("(это необходимо для резервирования памяти, чтобы выполнить задачу): ");
int number = Convert.ToInt32(Console.ReadLine());

// checking if "number" greater than zero.
while (number <= 0)
{
    Console.WriteLine("Ошибка ввода! введите другое число");
    number = Convert.ToInt32(Console.ReadLine());
}

// Array initialization.
int[] array = new int[number];

// Creating a new void method for to fill the array.
void FillArray(int[] collection)
{
    int a = 1;      // just a counter.
    for (int index = 0; index < number; index++)
    {
    Console.WriteLine("Введите число " + a + ": ");
    collection[index] = Convert.ToInt32(Console.ReadLine());
    a++;
    }
}

// Cheching values greater than zero.
int checkValue(int[] collection)
{
    int result = 0;

    for (int index = 0; index < number; index++)
    {
        if (collection[index] > 0) result++;
    }

    return result;
}

FillArray(array);

// Output the counter of values.
Console.WriteLine("Количество чисел, больших нуля: " + checkValue(array));