/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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

int[] ConvertArrayTo1D(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];

    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            k++;
        }
    }

    return result;
}

void SortArray1D(int[] inArray)
{
    int maxValue;

    for(int i = 0; i < inArray.Length; i++)
    {
        maxValue = inArray[i];
        for(int k = i + 1; k < inArray.Length; k++)
        {
            if(inArray[k] > maxValue)
            {
                inArray[i] = inArray[k];
                inArray[k] = maxValue;
                maxValue = inArray[i]; 
            }
        }    
    }
}

void PrintReport(int[] inArray)
{
    int currentValue = inArray[0];
    int currentQt = 1;

    for(int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i] == currentValue)
        {
            currentQt++;
        }
        else
        {
            Console.WriteLine($"{currentValue} встречается {currentQt} раз(а)");
            currentValue = inArray[i];
            currentQt = 1;
        }
    }

    Console.WriteLine($"{currentValue} встречается {currentQt} раз(а)");
}

Console.Clear();
int[,] array2D = GetArray(5, 5, -3, 3);
PrintArray(array2D);

int[] array1D = ConvertArrayTo1D(array2D);
SortArray1D(array1D);
PrintReport(array1D);