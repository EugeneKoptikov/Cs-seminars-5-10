// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Input
Console.WriteLine("Программа расчитывает координаты точки пересечения на плоскости через систему уравнений.");
Console.WriteLine("Укажите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

/*
{y = k1 * x + b1    -- система ураввнений с 2 неизвестными.
{y = k2 * x + b2

Находим х:
y - y = k1 * x + b1 - (k2 * x + b2)
y - y = k1 * x + b1 - k2 * x - b1 
0 = x * (k1 - k2) + b1 - b2
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)

При нахождении у достаточно подставить найденное значение х в одно из двух уравнений системы.
*/

// Finding value of "x".
double ValueX(double arg1, double arg2, double arg3, double arg4)
{
    double x = (arg3 - arg1) / (arg2 - arg4);
    return x;
}

// finding value of "y".
double ValueY(double arg1, double arg2, double arg3)
{
    double y = arg2 * arg3 + arg1;
    return y;
}

// checking if k1 equals k2, and output answer.
if (k1 == k2) Console.WriteLine("Пересечения не найдено. Прямые параллельны!");
else Console.WriteLine("Координаты точки на плоскости: (" + ValueX(b1, k1, b2, k2) + "; " + ValueY(b1, k1, ValueX(b1, k1, b2, k2)) + ")");