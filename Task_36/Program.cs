﻿// Программа, которая будет принимать на вход число и возвращать сумму его цифр.
int SumDigital(int number)
{
if (number == 0)
{
return 0;
}
return number % 10 + SumDigital(number / 10);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigital(number));