/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
 */

 string ConvertToBinary(int number)
{
    if (number == 0) return "0";

    string text = "";

    while(number > 0)
    {
        text = (number % 2).ToString() + text;
        number /= 2;
    }
    return text;
}

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(ConvertToBinary(number));