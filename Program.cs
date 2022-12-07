// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m, n];
CreateArray(array);
void CreateArray (double [,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble()*100, 2);
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//SearchElement(array);
void SearchElement(double[,] arr)
{
    Console.WriteLine("Введите позиции элемента в массиве: ");
    Console.Write("В строке: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("В столбце: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (line < 0 || line > arr.GetLength(0)-1 || column < 0 || column > arr.GetLength(1)-1)
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else Console.WriteLine($"Значение элемента в массиве: {arr[line,column]}");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;

//AmountColumns(array);
void AmountColumns(double[,] arr)
{
    Console.Write("Среднее арифметическое столбцов: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{ sum / arr.GetLength(0)} ");
    }
}
