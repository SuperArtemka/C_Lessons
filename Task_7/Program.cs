// Кратно ли второе число первому

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int mod = numberOne % numberTwo;

if(mod==0){
Console.Write("Кратно");
}
else{
Console.Write($"Остаток: {mod}");
}
