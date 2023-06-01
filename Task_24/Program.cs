// Теорема о неравенстве треугольника 

System.Console.WriteLine("Введите сторону A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
System.Console.WriteLine("Треуголник существует");
else
System.Console.WriteLine("Треуголник не существует");
