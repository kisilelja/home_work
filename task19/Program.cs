// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
int digit5 = A % 10;
int digit4 = A / 10 % 10;
int digit2 = A / 1000 % 10;
int digit1 = A / 10000;
if (A < 100000 && A > 9999)
{
    if ( digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}
