﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

Console.WriteLine ("Введите чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());

// if (a%7==0 && a%23==0 )
if (a%161==0)
    Console.WriteLine("Число кратное и 7 и 23");
else
    Console.WriteLine("Число не кратное и 7 и 23");
