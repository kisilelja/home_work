// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массив
double []  array = {12, 1,  12.3, 54, 78, 65, 41, 526.3, 89.5};
double difference = 0;
double max = array [0]; 
double min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if ( array [i]   > max )
    {
        max = array [i] ;
    }
    if (array[i] < min)
    {
        min = array [i];
    }
    
}
Console.WriteLine (string.Join(", ", array));
Console.WriteLine($"Минимальный элемент массива равен {min}, Максимальный элемент массива равен {max}");
Console.WriteLine($"Разность между минимальным элементом массива  и максимальным элементом массива равен {max-min}");
