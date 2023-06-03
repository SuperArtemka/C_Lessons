// Двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void Sqare(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i += 2)
{
for (int j = 0; j < matrix.GetLength(1); j += 2)
{
matrix[i, j] = matrix[i, j] * matrix[i, j];
}
}
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

Sqare(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);
