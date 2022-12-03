// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
Console.WriteLine ("Введите чиcло дня недели");
int a = Convert.ToInt32 (Console.ReadLine ());
int i=0,j=0;
int[,]ned = new int[2,7]{{1,2,3,4,5,6,7},{1,1,1,1,1,2,2}};
if (a>=1 && a<=7)
{
    while (j <= ned.GetUpperBound(1))
    {
        if (a==ned[i,j])
        {
            if (ned[i+1,j]==1)
                Console.WriteLine ("рабочий день");
            else
                Console.WriteLine ("выходной день");
        }
        j++;
    }        
}
else
    Console.WriteLine("Такого дня недели нет");
