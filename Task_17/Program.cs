﻿// Массив из 8 элементов заполненный в случайном порядке нулями и единицами

int[] arr = new int[8];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 2);
    //System.Console.Write($"{arr[i]}");
}
System.Console.WriteLine('['+string.Join(",", arr)+']');