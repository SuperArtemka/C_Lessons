// Программа, которая выведет все натуральные числа в промежутке от 1 до N. 
void RoadToN(int number)
{
if (number == 0)
{
return;
}
RoadToN(number - 1);
System.Console.Write($"{number} ");

}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToN(number);