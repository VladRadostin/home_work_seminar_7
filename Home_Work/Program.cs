
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

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

void doubleRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double double_1 = new Random().NextDouble();
            int int_1 = new Random().Next(1, 100);
            array[i,j] = Math.Round(double_1, 2) + int_1;
        }
    }
}

int m = 0;
int n = 0;

m = Prompt($"Введите число столбцов ");
n = Prompt($"Введите число строк ");

double[,] array = new double[m,n];

PrintArray(array);
doubleRandom(array);
PrintArray(array);