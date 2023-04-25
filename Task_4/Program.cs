// Нахождение последней цифры трехзначного числа

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastNumber = 0;

if(number > 99 && number < 1000){
    lastNumber = number % 10;
    Console.Write($"Последняя цифра в {number} равна {lastNumber}");
} 
else
{
    Console.Write("Это не трехзначное число");
}
