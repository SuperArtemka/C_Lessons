// Диапазон координат по вводимой четверти

void QuatersFind(int x)
{
    if (x == 1)
    {
        Console.WriteLine("Доступные координаты x > 0 и у > 0");
    }
    else if (x == 2)
    {
        Console.WriteLine("Доступные координаты x < 0 и у > 0");
    }
    else if (x == 3)
    {
        Console.WriteLine("Доступные координаты x < 0 и у < 0");
    }
    else if (x == 4)
    {
        Console.WriteLine("Доступные координаты x > 0 и у < 0");
    }
    else
    {
        Console.WriteLine("Введите номер четверти от 1 до 4");
    }
}
Console.Write("Введите номер четверти от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());
QuatersFind(x);

/*
string[] quaters = {
x > 0 и у > 0,
x < 0 и у > 0,
x < 0 и у < 0,
x > 0 и у < 0
};
Console.Write("Введите номер четверти от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());
if (quarter >= 1 && quarter <=4){
    Console.WriteLine(quarter[quarter-1]);
}
else{
    Console.WriteLine("Введите номер четверти от 1 до 4");
}

}
*/

