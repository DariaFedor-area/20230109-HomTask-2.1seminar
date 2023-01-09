/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

/* Задача 10: Напишите программу, которая принимает 
 на вход трёхзначное число и на выходе показывает 
 вторую цифру этого числа.

456 -> 5
782 -> 8 
918 -> 1
*/


Console.Clear();

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int number_2 = ((number % 100)/10);
    Console.WriteLine(number_2);
}
else
{
    Console.WriteLine("вы ввели не трехзначное число");
}


