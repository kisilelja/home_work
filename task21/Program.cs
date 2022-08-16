// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки F по X оси ");
int Fx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки F по Y оси ");
int Fy = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки F по Z оси ");
int Fz = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по X оси ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по Y оси ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по Z оси ");
int Bz = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((Fx-Bx),2) + Math.Pow((Fy-By),2) + Math.Pow((Fz-Bz),2));
Console.WriteLine($"{result:f2}");