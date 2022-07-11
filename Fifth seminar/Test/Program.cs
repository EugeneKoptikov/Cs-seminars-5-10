Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];

double Raznicha(double[] collection)
{
   
    Random rand = new Random();
    double razn = 0;
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<collection.Length; i++)
    {
        array[i] = rand.Next(1, 10000);
        Console.Write(" " + array[i]); 
    }   
    double min = 100000;
    double max = 0;
     for (int i = 0; i<array.Length; i++)
     {
        if (collection[i] > max)
        {
            max = collection[i];
        }
        else if (collection[i] < min)
        {
            min = collection[i];
        }
        
        razn = max - min;
     }
     return razn;
}


double result = Raznicha(array);
Console.WriteLine("");
Console.WriteLine("Разница между максимумом и минимумом  = " + result);