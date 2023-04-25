// Вывод дня недели по номеру

Console.Write("Введите число от 1 до 7 :");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 1){
    Console.Write("Это понедельник");
}

else if(dayNumber == 2){
    Console.Write("Это вторник");
}

else if(dayNumber == 3){
    Console.Write("Это среда");
}

else if(dayNumber == 4){
    Console.Write("Это четверг");
}

else if(dayNumber == 5){
    Console.Write("Это пятница");
}

else if(dayNumber == 6){
    Console.Write("Это суббота");
}

else if(dayNumber == 7){
    Console.Write("Это воскресение");
}
else
{
    Console.Write("Этому числу не соответствует ни один день недели!");
}