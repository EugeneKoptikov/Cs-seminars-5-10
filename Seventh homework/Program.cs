// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Input
Console.WriteLine("Input number in string (m): ");
string m = Console.ReadLine();
int stringNumber = Number(m);
Console.WriteLine("Input number in column (n): ");
string n = Console.ReadLine();
int columnNumber = Number(n);

// The method for checking input values.
int Number(string str)
{
    int number = 0;
    string textBufer = string.Empty;
    
    while (number <= 0)
    {
        bool v = false;

        while (v == false)
        {
            int index = 0;
  
            while (index < str.Length)
            {
                char symbol = str[index];

                if( symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || 
                    symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || 
                    symbol == '9' || symbol == '0')
                {
                    textBufer = textBufer + symbol;
                }

                index++;    
            }

            if (textBufer.Length < str.Length)
            {
                Console.WriteLine("Input only number greater than zero, again:");
                v = false;
                str = Console.ReadLine();
                
            }
            
            if (textBufer.Length == str.Length)
            {
                v = true;
                number = Convert.ToInt32(str);
                 
            }
        }

        if (number == 0)
        {
            Console.WriteLine("Input number greater than zero, again:");
            v = false;
            str = Console.ReadLine();
        }
    }
    return number;
}

// An array initialization and filling it.
int[,] array = new int[5, 5];

void RandomFillArray(int[,] collection)
{
    for (int index = 0; index < collection.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < collection.GetLength(1); jndex++)
        {
            collection[index, jndex] = new Random().Next(-100, 100);
        }
    }
}

// Printing the array and the element.
void PrintArray(int[,] collection)
{
    for (int index = 0; index < collection.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < collection.GetLength(1); jndex++)
        {
            if (jndex == 0)
            {
                Console.Write("[");
            }

            Console.Write(collection[index, jndex]);

            if (jndex < collection.GetLength(1) - 1)
            {
                Console.Write(", ");
            }

            if (jndex == collection.GetLength(1) - 1)
            {
                Console.Write("]");
                Console.WriteLine("");
            }
        }
    }
}

void PrintArrayElement(int[,] collection, int arg1, int arg2)
{
    if (arg1 > 0 && arg1 < collection.GetLength(0))
    {
        if (arg2 > 0 && arg2 < collection.GetLength(1)) 
        {
            Console.WriteLine("Value of array element [" + arg1 + ", " + arg2 + "]: " + collection[arg1, arg2]);
        }
        else 
        {
            Console.WriteLine("This element [" + arg1 + ", " + arg2 + "] does not exist in the array.");
        }
    }
    else
    {
        Console.WriteLine("This element [" + arg1 + ", " + arg2 + "] does not exist in the array.");
    }
}

RandomFillArray(array);
PrintArray(array);
PrintArrayElement(array, stringNumber, columnNumber);