// Напишите программу, которая на вход принимает число (N), 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите  число");
int N = int.Parse(Console.ReadLine());
int digit = 1;
while (digit <= N)
{
    Console.Write(digit*digit*digit);
    Console.Write(", ");
    digit = digit + 1;
}
