// Кратность одновременно двум числам

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0){

Console.Write("Кратно");
}
else{
Console.Write("Некратно");
}