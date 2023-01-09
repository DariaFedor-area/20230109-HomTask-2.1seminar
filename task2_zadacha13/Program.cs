/* // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

/* Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("введите число");

int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("введенное число имеет менее трех цифр");
}
else{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.WriteLine($"третья цифра введенного числа = {number % 10}");
}
