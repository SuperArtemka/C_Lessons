//Сумма отрицательных и положительных элементов рандомного массива

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}
System.Console.WriteLine("Введите число: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join(",", array));

int sumPositiv = 0;
int sumNegativ = 0;
for (int i = 0; i < array.Length; i++){
    if(array[i]> 0){
        sumPositiv+= array[i];
    }
    else {
        sumNegativ+= array[i];
    }
}
System.Console.WriteLine($"Сумма положительных чисел: {sumPositiv} Сумма отрицательных чисел: {sumNegativ}");