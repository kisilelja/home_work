﻿// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int [] array = new  int [15];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if ( array[i] % 2 == 0)
    {
        count++;
    }

}
Console.WriteLine (string.Join(", ", array));
Console.WriteLine($"Количество положительных элементов равно {count}");