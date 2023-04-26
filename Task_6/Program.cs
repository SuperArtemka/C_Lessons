// Удаление второй цифры трехзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int digit1 = number / 100;
int digit3 = number % 10;
int result = digit1 * 10 + digit3;

Console.WriteLine($"После удаления второй цифры останется: {result}");