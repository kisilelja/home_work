// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int [] array = new int [15];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (0, 20);
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine (string.Join(", ", array));
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}");
