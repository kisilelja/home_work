// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
while (A > 0)
{
    sum = sum + A % 10;
    A = A / 10;
}
Console.WriteLine($"Сумма цифр числа равна {sum}");

