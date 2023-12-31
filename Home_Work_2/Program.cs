﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 100);
        }
    }
}

void Array(double[,] array)
{
    double numbers = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        numbers = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers = numbers + array[i,j];
        }
        numbers = numbers / array.GetLength(1);
        Console.WriteLine($"Среднее арифметическое {numbers}");
    }
    Console.WriteLine();
}


double[,] array = new double[3,4];

FillArrayRandom(array);
PrintArray(array);
Array(array);
