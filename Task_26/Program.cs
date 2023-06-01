//  Вывод первых N чисел Фибоначчи без рекурсии

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
int num1 = 0; // сосед №1
int num2 = 1; // сосед №2

System.Console.Write("0 1 ");

for (int i = 2; i < n; i++)
{
res = num1 + num2;
System.Console.Write($"{res} ");
num1 = num2;
num2 = res;
}

