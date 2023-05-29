﻿// Замена положительных элементов массива на отрицательные и наоборот
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

int[] ChangeArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1;
}
return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", ChangeArray(array)));
