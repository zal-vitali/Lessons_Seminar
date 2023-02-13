/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21/*  */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] MultiArray(int[] array)
{
    int size;
/*     if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
       size = array.Length / 2 + 1; 
    } */
    size = (array.Length % 2 == 0) ? array.Length / 2 : array.Length / 2 + 1;
    //size = (array.Length / 2) ? (array.Length % 2 == 0) : (array.Length / 2 + 1);
    
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 0)
    {
        result[size-1] = array[size-1] * array[size];
    }
    else
    {
        result[size-1] = array[size-1];
    }

    return result;
}


Console.Clear();

int[] array = GetArray(7, -9, 9);
Console.WriteLine(String.Join(" ,", array));

int[] multiArray = MultiArray(array);
Console.WriteLine(String.Join(" ,", multiArray));