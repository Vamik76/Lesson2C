// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трехзначное чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
int b = a % 100 / 10;
Console.WriteLine ("десятки: " +b);