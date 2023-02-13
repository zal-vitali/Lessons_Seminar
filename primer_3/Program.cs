//Программа получает два числа и определяет, является ли второе число кратным первому
// 

Console.Clear();

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 == 0) Console.WriteLine("Делитель равен нулю!");
else
{
    int result = number1 % number2;
    if (result == 0)
    {
        Console.WriteLine($"Число {number1} кратно числу {number2}");
    }
    else
    {
        Console.WriteLine($"Число {number1} некратно числу {number2}. Остаток от деления: {result}");
    }
}