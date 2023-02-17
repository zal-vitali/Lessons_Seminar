/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
 */

bool TriangleIsPossible(int a, int b, int c)
{
    return ((a < (b + c)) && (b < (a + c)) && (c < (a + b)));
}

Console.Clear();
Console.WriteLine("Введите три числа");
Console.WriteLine("Первое");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Второе");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Третье");
int c = int.Parse(Console.ReadLine()!);

if (TriangleIsPossible(a, b, c))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольника не существует");
}