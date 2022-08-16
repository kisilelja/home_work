// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());

if ( A > 0 && A < 6)
{
  Console.WriteLine("Это не выходной день");
}
else if ( A == 6 || A ==7)
{
    Console.WriteLine("Это выходной день");
}
else 
 {
    Console.WriteLine ("Нет такого дня недели");
 }