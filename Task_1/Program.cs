// Является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if(numberOne == numberTwo * numberTwo){
    Console.Write("Первое введенное число - это квадрат второго");
} else {
    Console.Write("Попробуйте снова");
}
