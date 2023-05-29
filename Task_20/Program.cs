﻿// Поиск заданного числа в массиве
int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

System.Console.Write("Введите число, которое хотите найти: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isOk = false;

for (int i = 0; i < array.Length; i++)
{
if (number == array[i])
{
isOk = true;
break;
}
}
if (isOk)
{
System.Console.WriteLine("Элемент найден");
}
else
{
System.Console.WriteLine("Элемент не найден");
}
