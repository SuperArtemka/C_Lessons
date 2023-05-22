// Количество цифр в числе

int Counting(int number){
    int count = 0;
    while(number>0){
        number/=10;
        count++;        
        }
        if (count == 0){
            count++;
        }
    return count;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = Counting(num);
System.Console.WriteLine($"Количество цифр в числе {num} = {count}");

/*Второй вариант решения

System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if(int.TryParse(num, out int number)){
    System.Console.WriteLine(num.Length);
}
else{
    System.Console.WriteLine("Ошибка! Введите число.");
}
*/