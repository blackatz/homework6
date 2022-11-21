//Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа для поиска точки пересечения прямых");
Console.WriteLine("Введите k1: ");

double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите b1: ");

double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите k2: ");

double k2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите b2: ");

double b2 = double.Parse(Console.ReadLine()!);

double Find(double k1, double b1, double k2, double b2)
    {   double x = 0;
        double y = 0;
        if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
        else 
        {
        x = (b2-b1)/(k1-k2);
        y = k2 * x + b2;
        }
        Console.WriteLine("Координаты точки пересечения: " + x + ";" + y);
        return x;
    }

Find(k1, b1, k2, b2);