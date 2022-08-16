// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
if (A > 100 && A < 999)
{
   int digit2 = (A/10)%10;
   Console.WriteLine($"Вторая цифра числа равна {digit2}"); 
}
else 
{
    Console.WriteLine("Данное число не трехзначное");
}
