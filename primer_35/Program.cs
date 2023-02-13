﻿/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int CalcElements(int[] array, int left, int right)
{
    int quant = 0;
    foreach(int element in array)
    {
        if((element >= left) && (element <= right))
        quant ++;
    }
    return quant;
}


Console.Clear();

int[] array = GetArray(123, -99, 99);
Console.WriteLine(String.Join(" ,", array));
int quant = CalcElements(array,10,99);
Console.WriteLine("------");
Console.WriteLine(quant);