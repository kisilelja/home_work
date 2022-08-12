// Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int C = int.Parse(Console.ReadLine());
int max = A;
if (B > A)
{
    max = B;
}
if (C > B)
{
    max = C;
}
Console.Write("Максимальное число ");
Console.WriteLine(max);

