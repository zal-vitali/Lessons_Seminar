﻿/* Задача 51: Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с
индексами (0,0); (1;1) и т.д.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной
диагонали: 1+9+2 = 12 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int GetSumMainDiag(int[,] inArray)
{
    int minValue = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    int sumMainDiag = 0;

    for (int i = 0; i < minValue; i++)
    {
        sumMainDiag += inArray[i,i];
    }

    return sumMainDiag;
}

Console.Clear();
int[,] array = GetArray(4, 3, -10, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали равна {GetSumMainDiag(array)}");