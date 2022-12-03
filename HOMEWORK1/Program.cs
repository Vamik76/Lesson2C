// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите чиcло");
int a = Convert.ToInt32 (Console.ReadLine ());
int b = a / 100;
if (b == 0)
    Console.WriteLine ("Третьей цифры нет");
else
{
    if (b>9)
    {
        b=b%10;
        Console.WriteLine ("третья цифра: " +b);
    }
    else
        Console.WriteLine ("третья цифра: " +b);
}
    


