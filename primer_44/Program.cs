/*  Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

double[] Fibonacci(int n)
{
    double[] result = new double[n];
    if (n < 2)
    {
        result[0] = 0;
    }
    else
    {
        result[1] = 1;
        for (int i = 2; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }
    }

    return result;
}

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

double[] result = Fibonacci(number);

foreach (double elem in result)
{
    Console.WriteLine(elem);
}

