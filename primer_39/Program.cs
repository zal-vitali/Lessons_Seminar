/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

void ReverseArray(int[] array)
{
    //int size;

    //size = (array.Length % 2 == 0) ? array.Length / 2 : array.Length / 2 + 1;
  
    
    //int[] result = new int[array.Length];
   //int[] result = array;

    for(int i = 0; i <= array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

    //return array;
}

int[] ReverseArray2(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i <= array.Length - 1; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

Console.Clear();

int[] array = GetArray(7, -9, 9);
Console.WriteLine(String.Join(" ,", array));

ReverseArray(array);
Console.WriteLine(String.Join(" ,", array));

int[] revArray = ReverseArray2(array);
Console.WriteLine(String.Join(" ,", revArray));
