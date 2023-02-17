/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.  */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] array = GetArray(10,-10,10);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine(String.Join(", ", CopyArray(array)));
