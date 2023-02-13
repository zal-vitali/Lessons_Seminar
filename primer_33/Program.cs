/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

bool FindNunberToArray(int[] array, int number)
{
    foreach(int element in array)
    {
        if(element == number)
        {
            return true;
        }
    }
    return false;
}

Console.Clear();

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int[] array = GetArray(20, -10, 20);
Console.WriteLine(String.Join(" ,", array));

if (FindNunberToArray(array, number))
{
    Console.WriteLine($"Число {number} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {number} отсутствует в массиве");
}