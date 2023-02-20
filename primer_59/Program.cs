/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

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

int[] GetMinValueAdress(int[,] inArray)
{
    int[] result = new int[2];
    int minValue = inArray[0, 0];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < minValue)
            {
                minValue = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    //Console.WriteLine(minValue);
    //Console.WriteLine(result[0]);
    //Console.WriteLine(result[1]);
    return result;
}

int[,] ShrinkArray(int[,] inArray, int[] minValueAdress)
{
    int skipRow = minValueAdress[0];
    int skipCol = minValueAdress[1];

    int currentRow = 0;
    int currentCol = 0;

    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == skipRow) continue;
        else
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j == skipCol) continue;
                else
                {
                    result[currentRow, currentCol] = inArray[i, j];
                    currentCol++;
                }
            }

            currentCol = 0;
            currentRow++;
        }
    }

    return result;
}

Console.Clear();
int[,] array = GetArray(3, 3, 1, 9);
PrintArray(array);

Console.WriteLine();
int[] minValueAdress = GetMinValueAdress(array);

int[,] resultArray = ShrinkArray(array, minValueAdress);
PrintArray(resultArray);