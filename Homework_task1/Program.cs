﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3*/

Console.Clear();

Console.Write("Введите первое число:");

string input1 = Console.ReadLine(); // считывает код пользователя
int number1 = Convert.ToInt32(input1);

Console.Write("Введите второе число:");

string input2 = Console.ReadLine(); // считывает код пользователя
int number2 = Convert.ToInt32(input2);


if (number2 > number1)
{
Console.WriteLine("max= " + number2 + " min= " + number1);
}

else
{
    Console.WriteLine("max= " + number1 + " min= " + number2);
}
