/* // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("введите число от 1 до 7, где 1=понедельник, 7=воскресенье");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("введите число от 1 до 7");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("это выходной день недели");
    }
    else
    {
        Console.WriteLine("этот день является будним");
    }
}


