// Программа, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
int Pow(int a, int b)
{
if (b == 0)
{
return 1;
}
return a * Pow(a, b - 1);
}

System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Pow(a, b));