// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк: ");
int linesVol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = int.Parse(Console.ReadLine());
int[,] array = new int[linesVol, columnsVol];
int[,] secondArray = new int[linesVol, columnsVol];
int[,] resultArray = new int[linesVol, columnsVol];

if (linesVol <= 0 & columnsVol <= 0)
{
    Console.WriteLine(" Нельзя вывести массив ");
    return;
}

FillArrayRandom(array);
PrintArray2D(array);
Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);
Console.WriteLine();

// Функция перемножения массивов
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);


// Функция заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}