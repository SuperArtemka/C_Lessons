//Вывод расстояния между точками по координатам
/* 
System.Console.WriteLine(Math.Pow(12, 2)); - возведение в стерень
System.Console.WriteLine(Math.Sqrt(144));  - квадратный корень
System.Console.WriteLine(Math.Round(12.24244, 2)); - округление  числа
*/

double dist2D(double x1, double x2, double y1, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)),2);
}

System.Console.WriteLine("Введите координаты точки А по оси х: ");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси х: ");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси y: ");
double y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(dist2D(x1, y1, x2, y2));

/*
System.Console.WriteLine("Введите координаты точки А по оси х: ");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси х: ");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси y: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double point = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
System.Console.WriteLine(Math.Round(point, 2));
*/