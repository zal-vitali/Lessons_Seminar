﻿//Написать программу, которая выводит случайное число из интервала 10-99 и 
//показывает наибольшую цифру этого числа

Console.Clear();

int num = new Random().Next(10, 100);
// 123 / 10 = 12; 123 % 10 = 3;
int a1 = num / 10;
int a2 = num % 10;

int max = a1;

if (max < a2) 
{
    max = a2;
}

Console.WriteLine($"Максимальная цифра числа {num} равна {max}");