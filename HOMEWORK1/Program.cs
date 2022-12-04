// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
int b = a / 100 % 10;
if (b==0)
    Console.WriteLine ("Третьей цифры нет");
else
    Console.WriteLine ("третья цифра: " +b);
    


