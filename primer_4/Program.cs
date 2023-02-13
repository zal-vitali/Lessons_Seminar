//Принять на входе число и определить, кратно ли оно и 23 и 7

Console.Clear();

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);

string result = "NO";

if (number % 7 == 0)

{
    if (number % 23 == 0)
    result = "YES";
}

Console.WriteLine($"Число {number} - {result}");
