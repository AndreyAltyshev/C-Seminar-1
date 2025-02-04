﻿/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

//Блок функций

bool Squar(int number1, int number2)
{
    return number1 / number2 == number2 || number2 / number1 == number1;
 }

//Тело программы

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (Squar(num1, num2)) Console.WriteLine("да");
else Console.WriteLine("нет");
