// Определение четверти по координатам точки 
void QuatersFind(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка расположена в первой четверти.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка расположена во второй четверти.");
    }

    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка расположена в третьей четверти.");
    }

    else
    {
        Console.WriteLine("Точка расположена в четвертой четверти.");
    }
}

Console.WriteLine("Введите координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());
QuatersFind(x, y);

/*
string QuatersFindWithReturn(int x, int y)
{
    result = " ";
    if (x > 0 && y > 0)
    {
        result = "Точка расположена в первой четверти.";
    }
    else if (x < 0 && y > 0)
    {
        result = "Точка расположена во второй четверти.";
    }

    else if (x < 0 && y < 0)
    {
        result = "Точка расположена в третьей четверти.";
    }

    else
    {
        result = "Точка расположена в четвертой четверти.";
    }
    return result;
}

Console.WriteLine("Введите координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string quater = QuatersFindWithReturn(x, y);
Console.WriteLine(quater);
*/

