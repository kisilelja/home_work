// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Ввведите число, равное тому, сколько раз вы будете вводить раз числа ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++ )
{
    Console.WriteLine("Ввведите число ");
    int n = int.Parse(Console.ReadLine());
    if ( n > 0)
    {
        count ++;
    }
}
Console.WriteLine($"{count} раз пользователь ввел числа больше нуля");