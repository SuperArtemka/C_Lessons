﻿// Двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 11);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
}
}

int Sum(int[,] matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i == j)
{
sum += matrix[i, j];
}
}
}
return sum;
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine(Sum(matrix));