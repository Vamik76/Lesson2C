﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.WriteLine ("Введите первое чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе чиcло");
int n=0;
int b = Convert.ToInt32 (Console.ReadLine ());
if (a%b==0)
    Console.WriteLine("Число кратное");
else
{
    n = a%b;
    Console.WriteLine("Остаток от деления "+n);
}