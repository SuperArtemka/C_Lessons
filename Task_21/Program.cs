//Количество элементов одномерного массива, значения которых лежат в отрезке [10,99].

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 300);
}
return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
{
count++;
}
}
System.Console.WriteLine(count);
