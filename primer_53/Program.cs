/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

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

void ProcessArray(int[,] inArray)
{
    int tempValue;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        tempValue = inArray[0,i];
        inArray[0,i] = inArray[inArray.GetLength(0)-1,i];
        inArray[inArray.GetLength(0)-1,i] = tempValue;
    }
}

Console.Clear();
int[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);
ProcessArray(array);
Console.WriteLine();
PrintArray(array);