// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine ("Введите первое чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе чиcло");
int b = Convert.ToInt32 (Console.ReadLine ());
if (a*a==b)
    Console.WriteLine(b+" = квадрату "+a);
else
    Console.WriteLine(b+" не = квадрату "+a);
if (b*b==a)
    Console.WriteLine(a+" = квадрату "+b);
else
    Console.WriteLine(a+" не = квадрату "+b);