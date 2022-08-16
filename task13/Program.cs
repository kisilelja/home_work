// Найти третью цифру числа или сообщить, что её нет 
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine($"Дано число: {Number}");

if (Number >= 1000)
{
    while (Number >= 1000)
    {
        Number = Number/10;
    }
    int digit3 = Number%10;
    Console.WriteLine($"Третья цифра числа равна {digit3}");
}
else if (Number > 99 && Number < 1000)
{
    Console.WriteLine($"Третья цифра числа равна {Number%10}");
}
else
{
    Console.WriteLine("У числа нет третьей цифры!");
}
