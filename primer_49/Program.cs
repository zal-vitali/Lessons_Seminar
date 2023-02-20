/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 49 2
5 81 2 9
64 4 4 4 */

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
    for (int i = 0; i < inArray.GetLength(0); i+=2)
    {
        for (int j = 0; j < inArray.GetLength(1); j+=2)
        {
            inArray[i,j] *= inArray[i,j];
        }
    }
}

Console.Clear();
int[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);
ProcessArray(array);
Console.WriteLine();
PrintArray(array);
