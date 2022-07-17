// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// input
Console.WriteLine("Input size of strings (m): ");
string m = Console.ReadLine();
int strings = Number(m);
Console.WriteLine("Input size of columns (n): ");
string n = Console.ReadLine();
int columns = Number(n);

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

// An array initialization.
double[,] array = new double[strings, columns];

// Filling the array.
void RandomFillArray(double[,] collection)
{
    for (int index = 0; index < collection.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < collection.GetLength(1); jndex++)
        {
            collection[index, jndex] = new Random().Next(-100, 100) + new Random().NextDouble();
        }
    }
}

// Printing the array.
void PrintArray(double[,] collection)
{
    for (int index = 0; index < collection.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < collection.GetLength(1); jndex++)
        {
            if (jndex == 0)
            {
                Console.Write("[");
            }

            Console.Write(string.Format("{0:N2}", collection[index, jndex]));

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

RandomFillArray(array);
PrintArray(array);