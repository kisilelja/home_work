// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());
if (A>B)
{
    Console.Write("Максимальное  число равно  ");
    Console.WriteLine(A);
    Console.Write("Минимальное  число равно  ");
    Console.WriteLine(B);
}
else
{
   Console.Write("Максимальное  число равно  ");
    Console.WriteLine(B);
    Console.Write("Минимальное  число равно  ");
    Console.WriteLine(A); 
}