// Разворот одномерного массива

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

int temp = 0;

for (int i = 0; i < array.Length / 2; i++)
{
temp = array[i];
array[i] = array[array.Length - i - 1];
array[array.Length - i - 1] = temp;
}

System.Console.WriteLine(string.Join(", ", array));