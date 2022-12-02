// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.WriteLine ("Введите первое чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе чиcло");
int b = Convert.ToInt32 (Console.ReadLine ());
int n = a%b;
if (n==0)
    Console.WriteLine("Число кратное");
else
    Console.WriteLine("Остаток от деления "+n);
