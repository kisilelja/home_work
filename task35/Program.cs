// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int [] array = new int [123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (-100, 1000);
    if (array[i] < 99 && array[i] > 9)
    {
        count ++;
    }
}
Console.WriteLine (string.Join(", ", array));
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");
